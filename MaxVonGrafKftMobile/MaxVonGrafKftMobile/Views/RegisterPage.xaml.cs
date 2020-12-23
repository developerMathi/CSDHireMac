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
    public partial class RegisterPage : ContentPage
    {
        CustomerReview customer;
        CustomerSerach customerSerach;
        List<CustomerSeachResult> customerSeachResults;
        public RegisterPage()
        {
            InitializeComponent();

            customer = new CustomerReview();
            customerSerach = new CustomerSerach();
            customerSeachResults = null;
            //var assembly = typeof(LoginPage);
            //regiseterNxtBtn.ImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.nextIcon.png", assembly);
            //registerPageImage.Source= ImageSource.FromResource("MaxVonGrafKftMobile.Assets.registerPageImage.png", assembly); 
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

        private async void RegiseterNxtBtn_Clicked(object sender, EventArgs e)
        {
            if (!new EmailAddressAttribute().IsValid(emailEntry.Text) || string.IsNullOrEmpty(emailEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid email address"));
            }
            else if (!(emailEntry.Text == ConfirmemailEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("“Confirm Email mismatch with Email"));
                ConfirmemailEntry.Text = null;
            }
            else if (string.IsNullOrEmpty(PasswordEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid Password"));
            }
            else if (PasswordEntry.Text.Length < 6)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Password must be atleast with 6 characters."));
            }
            else if (!(PasswordEntry.Text == ConfirmPasswordEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Password does not match. Please re-enter the confirm password"));
                ConfirmPasswordEntry.Text = null;
            }

            else
            {
                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        regiseterNxtBtn.IsVisible = false;
                        NextSpinnerFrame.IsVisible = true;
                        nextSpinner.IsRunning = true;
                        customerSerach.Email = emailEntry.Text;
                        customerSerach.Active = true;
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




                            if (App.Current.Properties.ContainsKey("currentToken"))
                            {
                                App.Current.Properties["currentToken"] = apiToken.access_token;
                            }
                            else
                            {
                                App.Current.Properties.Add("currentToken", apiToken.access_token);
                            }
                            CustomerController customerController = new CustomerController();
                            try
                            {
                                customerSeachResults = customerController.getCustomerByFilter(customerSerach, apiToken.access_token);
                            }
                            catch (Exception ex)
                            {
                                PopupNavigation.Instance.PushAsync(new Error_popup(ex.Message));
                            }
                        });
                    }
                    finally
                    {
                        busy = false;
                        customer.Email = emailEntry.Text;
                        customer.Password = PasswordEntry.Text;
                        customer.ClientId = Constants.ClientId;

                        NextSpinnerFrame.IsVisible = false;
                        nextSpinner.IsRunning = false;
                        regiseterNxtBtn.IsVisible = true;

                        if (customerSeachResults != null)
                        {
                            if (customerSeachResults.Count > 0)
                            {
                                bool isExisting = false;
                                foreach (CustomerSeachResult csr in customerSeachResults)
                                {
                                    if (csr.Email.ToLower() == emailEntry.Text.ToLower())
                                    {
                                        isExisting = true;
                                    }
                                }
                                if (isExisting)
                                {
                                    await PopupNavigation.Instance.PushAsync(new Error_popup("Email address already exist. Please try with another email address."));
                                }
                                else
                                {
                                    await Navigation.PushAsync(new AddPersonalInformationPage(customer));
                                }
                            }
                            else
                            {
                                await Navigation.PushAsync(new AddPersonalInformationPage(customer));
                            }
                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup("Something went wrong, please check your internet connection"));
                        }

                        //if (customerSeachResults.Count == 0)
                        //{

                        //}
                        //else
                        //{
                        //    await PopupNavigation.Instance.PushAsync(new Error_popup("Email already exist. Please use another email address."));
                        //}


                    }
                }



            }
        }
        protected override bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0) { return true; }

            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            return false;
        }
    }
}