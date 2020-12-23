using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class WelcomPage : ContentPage
    {
        public WelcomPage()
        {
            InitializeComponent();
            var assembly = typeof(WelcomPage);

            //if (UIScreen.MainScreen.Bounds.Height >= 568)
            //{
            //    BackgroundImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.CSDLPortait.png", assembly); 
            //}
            //else
            //{
            //    BackgroundImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.CSDLandscape.jpg", assembly);
            //}


            logoImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logo_high_resolution_white-1.png", assembly);
            if (!App.Current.Properties.ContainsKey("CustomerId"))
            {
                App.Current.Properties.Add("CustomerId", 0);
            }

            var loginTap = new TapGestureRecognizer();
            loginTap.Tapped += async (s, e) =>
            {
                if ((int)App.Current.Properties["CustomerId"] == 0)
                {
                    await PopupNavigation.Instance.PushAsync(new AskForLogin("You must login before go to the Home page"));

                }
                else
                {
                    IsBusy = false;
                    if (!IsBusy)
                    {

                        
                        IsBusy = true;
                        await HomeBtn.FadeTo(0,100, Easing.SinInOut);
                        await loginBtnFrame.FadeTo(0, 100, Easing.SinInOut);
                        try
                        {
                            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(HomePage))
                            {
                                await Navigation.PushAsync(new HomePage());
                            }
                               
                        }
                        finally
                        {
                            IsBusy = false;
                            await HomeBtn.FadeTo(1, 1000);
                            await loginBtnFrame.FadeTo(1, 1000);

                        }
                    } 
                }
            };
            loginBtnFrame.GestureRecognizers.Add(loginTap);
            HomeBtn.GestureRecognizers.Add(loginTap);

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ErrorWithClosePagePopup))
                {
                    await PopupNavigation.Instance.PopAllAsync();
                }
            }

        }

        private async void BooknowBtn_Clicked(object sender, EventArgs e)
        {
            ApiToken apiToken = null;
            bool busy = false;
            if (!busy)
            {
                try
                {

                    busy = true;
                    BooknowBtn.IsVisible = false;
                    bookNowLoader.IsVisible = true;
                    bookNowSpinner.IsRunning = true;
                    
                    await Task.Run(async () =>
                    {
                        GetClientSecretTokenRequest getClientSecretTokenRequest = new GetClientSecretTokenRequest();
                        getClientSecretTokenRequest.ClientId = Constants.ClientId;
                        ApiController apiController = new ApiController();
                        GetClientSecretTokenResponse clientSecretTokenResponse = null;
                        try
                        {
                            clientSecretTokenResponse=apiController.GetClientSecretToken(getClientSecretTokenRequest);
                        }
                        catch (Exception ex)
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup(ex.Message));
                        }
                        if(clientSecretTokenResponse!= null)
                        {
                            GetAccessTokenRequest tokenRequest = new GetAccessTokenRequest();
                            tokenRequest.client_id = clientSecretTokenResponse.apiConsumerId;
                            tokenRequest.client_secret = clientSecretTokenResponse.apiConsumerSecret;
                            tokenRequest.grant_type = "client_credentials";

                            try
                            {
                                apiToken = apiController.GetAccessToken(tokenRequest);
                            }
                            catch (Exception ex)
                            {
                                await PopupNavigation.Instance.PushAsync(new Error_popup(ex.Message));
                            }
                            if (apiToken != null)
                            {
                                string _token = apiToken.access_token;

                                if (App.Current.Properties.ContainsKey("currentToken"))
                                {
                                    App.Current.Properties["currentToken"] = _token;
                                }
                                else
                                {
                                    App.Current.Properties.Add("currentToken", _token);
                                }
                            }
                                

                        }


                    });
                }
                
                finally
                {
                    if (apiToken!= null) {
                        await Navigation.PushAsync(new BookNow());
                    }
                    
                    busy = false;
                    BooknowBtn.IsVisible = true;
                    bookNowLoader.IsVisible = false;
                    bookNowSpinner.IsRunning = false;
                }
            }
        }

        protected override bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0) { return true; }
            else if (Navigation.NavigationStack.Count > 2)
            {
                return true;
            }
            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            return false;
        }

        //private void HomeBtn_Clicked(object sender, EventArgs e)
        //{
        //    if ((int)App.Current.Properties["CustomerId"] == 0)
        //    {
        //        PopupNavigation.Instance.PushAsync(new AskForLogin());

        //    }
        //    else
        //    {
        //        Navigation.PushAsync(new HomePage());
        //    }
        //}
    }
}