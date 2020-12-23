 using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MaxVonGrafKftMobile.Views
{
    public partial class LoginPage : ContentPage
    {
        CutomerAuthContext cutomerAuthContext = null;
        string token;
        public LoginPage()
        {
            InitializeComponent();
            var assembly= typeof(LoginPage);
            logoImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logo_high_resolution_white-1.png", assembly);
            emailIcon.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.emailIcon.png", assembly);
            passwordIcon.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.passwordIcon.png", assembly);
            //LoginButton.ImageSource= ImageSource.FromResource("MaxVonGrafKftMobile.Assets.LoginIcon.png", assembly);

            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                PopupNavigation.Instance.PopAllAsync();
            }


            var forgetPassword_tab = new TapGestureRecognizer();
            forgetPassword_tab.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new ForgetPasswordPage());
            };
            forgetPasswordLabel.GestureRecognizers.Add(forgetPassword_tab);
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

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(loginEmailAddress.Text))
            {
                errorLabel.Text = "Please enter a email address";
                errorLabel.IsVisible = true;
            }
            else if (!new EmailAddressAttribute().IsValid(loginEmailAddress.Text))
            {
                errorLabel.Text = "Email is not in a valid format";
                errorLabel.IsVisible = true;
            }
            else if (string.IsNullOrEmpty(loginPassword.Text))
            {
                errorLabel.Text = "Please enter a valid password";
                errorLabel.IsVisible = true;
            }
            else
            {
                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        LoginButton.IsVisible = false;
                        loginSpinnerFrame.IsVisible = true;
                        loginSpinner.IsRunning = true;
                        await Task.Run(() =>
                        {
                            GetClientSecretTokenRequest getClientSecretTokenRequest = new GetClientSecretTokenRequest();
                            getClientSecretTokenRequest.ClientId = Constants.ClientId;
                            ApiController apiController = new ApiController();
                            GetClientSecretTokenResponse clientSecretTokenResponse = apiController.GetClientSecretToken(getClientSecretTokenRequest);

                            GetAccessTokenRequest tokenRequest = new GetAccessTokenRequest();
                            tokenRequest.client_id = clientSecretTokenResponse.apiConsumerId;
                            tokenRequest.client_secret = clientSecretTokenResponse.apiConsumerSecret;
                            tokenRequest.grant_type = "client_credentials";
                            ApiToken apiToken = apiController.GetAccessToken(tokenRequest);
                             token = apiToken.access_token;

                            CustomerLogin loginCustomer = new CustomerLogin();
                            loginCustomer.email = loginEmailAddress.Text;
                            loginCustomer.Password = loginPassword.Text;
                            loginCustomer.clientId = Constants.ClientId;

                            
                            LoginController loginController = new LoginController();
                            cutomerAuthContext = loginController.CheckLogin(loginCustomer, token);
                        });
                    }
                    finally
                    {
                        busy = false;
                        loginSpinner.IsRunning = false;
                        loginSpinnerFrame.IsVisible = false;

                        LoginButton.IsVisible = true;
                        if(cutomerAuthContext!= null)
                        {
                            if (cutomerAuthContext.CustomerId > 0)
                            {
                                if (App.Current.Properties.ContainsKey("currentToken"))
                                {
                                    App.Current.Properties["currentToken"] = token;
                                }
                                else
                                {
                                    App.Current.Properties.Add("currentToken", token);
                                }

                                if (App.Current.Properties.ContainsKey("CustomerId"))
                                {
                                    App.Current.Properties["CustomerId"] = cutomerAuthContext.CustomerId;
                                }
                                else
                                {
                                    App.Current.Properties.Add("CustomerId", cutomerAuthContext.CustomerId);
                                }
                                Type type = typeof(WelcomPage);

                                if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() == type)
                                {
                                    await Navigation.PushAsync(new HomePage());
                                }
                                else
                                {
                                    await Navigation.PopAsync();
                                }

                            }
                            else
                            {
                                await PopupNavigation.Instance.PushAsync(new Error_popup("Log in failed . Please try again"));
                                loginPassword.Text = null;
                                errorLabel.IsVisible = false;
                            }

                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup("Log in failed . Please try again"));
                            loginPassword.Text = null;
                            errorLabel.IsVisible = false;
                        }

                    }
                }



                


                
                

            }
        }

        private void SignUpBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RegisterPage());
        }

        protected override bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0) { return true; }

            else if(Navigation.NavigationStack[Navigation.NavigationStack.Count-2].GetType() != typeof(WelcomPage))
            {
                PopupNavigation.Instance.PushAsync(new BookingLose());
                return true;
            }


            else if(Navigation.NavigationStack.Count > 1)
            {
                int c = Navigation.NavigationStack.Count;
                for (var counter = 1; counter < c - 1; counter++)
                {
                    Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                }
                return false;
            }
             
            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            return false;
        }

        private void backTool_Clicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() != typeof(WelcomPage))
            {
                PopupNavigation.Instance.PushAsync(new BookingLose());
            }


            else if (Navigation.NavigationStack.Count > 1)
            {
                int c = Navigation.NavigationStack.Count;
                for (var counter = 1; counter < c - 1; counter++)
                {
                    Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                }
                Navigation.PopAsync();
            }

            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            else
            {
                Navigation.PopAsync();
            }
        }

        private void backBtn_Clicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() != typeof(WelcomPage))
            {
                PopupNavigation.Instance.PushAsync(new BookingLose());
            }


            else if (Navigation.NavigationStack.Count > 1)
            {
                int c = Navigation.NavigationStack.Count;
                for (var counter = 1; counter < c - 1; counter++)
                {
                    Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                }
                Navigation.PopAsync();
            }

            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            else
            {
                Navigation.PopAsync();
            }
        }
    }
}