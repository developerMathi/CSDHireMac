using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAditionalDriver : ContentPage
    {
        private ReservationView reservationView;
        private SearchAllCustomerRequest searchAllCustomerRequest;
        private SearchAllCustomerResponse searchAllCustomerResponse;
        private string token;
        Driver driver;

        public AddAditionalDriver(ReservationView reservationView)
        {
            InitializeComponent();
            this.reservationView = reservationView;
            if (reservationView.CustomerDriverList == null)
            {
                reservationView.CustomerDriverList = new List<Driver>();
            }
            searchAllCustomerRequest = new SearchAllCustomerRequest();
            searchAllCustomerResponse = null;
            token = App.Current.Properties["currentToken"].ToString();
            driver = new Driver();

        }

        protected override async void OnAppearing()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ErrorWithClosePagePopup))
                {
                    await PopupNavigation.Instance.PopAllAsync();
                }
                else if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ReservationSavedPopup))
                {
                    await PopupNavigation.Instance.PopAllAsync();
                    await Navigation.PushAsync(new HomePageDetail());
                }

            }
        }

        [Obsolete]
        private async void submitBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FnameEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter First name."));
            }
            else if (string.IsNullOrEmpty(LnameEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter Last name."));
            }
            else if (string.IsNullOrEmpty(phoneEntry.Text) || phoneEntry.Text.Length < 10)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter valid phone number."));
            }

            else
            {
                searchAllCustomerRequest.filter = new CustomerSerach();
                searchAllCustomerRequest.filter.FirstName = FnameEntry.Text;
                searchAllCustomerRequest.filter.LastName = LnameEntry.Text;
                searchAllCustomerRequest.filter.hPhone = phoneEntry.Text;

                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        await PopupNavigation.Instance.PushAsync(new LoadingPopup("Checking for existing customers..."));

                        await Task.Run(() =>
                        {
                            try
                            {
                                searchAllCustomerResponse = getCustomerDetails(searchAllCustomerRequest, token);
                            }
                            catch (Exception ex)
                            {
                                PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(ex.Message));
                            }
                        });
                    }
                    finally
                    {
                        busy = false;
                        if (PopupNavigation.Instance.PopupStack.Count == 1)
                        {
                            await PopupNavigation.Instance.PopAllAsync();
                        }
                        if (PopupNavigation.Instance.PopupStack.Count > 1)
                        {
                            if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup))
                            {
                                await PopupNavigation.Instance.PopAllAsync();
                            }
                        }
                        if (searchAllCustomerResponse != null)
                        {
                            if (searchAllCustomerResponse.message.ErrorCode == "200")
                            {
                                if (searchAllCustomerResponse.serachResult.Count >0)
                                {
                                    
                                    driver.FirstName = searchAllCustomerResponse.serachResult[0].FirstName;
                                    driver.LastName = searchAllCustomerResponse.serachResult[0].LastName;
                                    driver.CustomerId = (int)searchAllCustomerResponse.serachResult[0].cust.CustomerId;
                                    driver.DateofBirth = searchAllCustomerResponse.serachResult[0].DateOfbirth;
                                    driver.DateofBirthStr = searchAllCustomerResponse.serachResult[0].DateOfbirth.ToString();
                                    driver.CreatedBy = searchAllCustomerResponse.serachResult[0].CreatedBy;
                                    driver.LastName = searchAllCustomerResponse.serachResult[0].LastName;
                                    driver.Email = searchAllCustomerResponse.serachResult[0].Email;
                                    driver.bPhone = searchAllCustomerResponse.serachResult[0].bPhone;
                                    driver.cPhone = searchAllCustomerResponse.serachResult[0].cPhone;
                                    driver.hPhone = searchAllCustomerResponse.serachResult[0].hPhone;
                                    driver.Address1 = searchAllCustomerResponse.serachResult[0].Address1;
                                    driver.StateId = searchAllCustomerResponse.serachResult[0].StateId;
                                    driver.DriverLicenseNumber = searchAllCustomerResponse.serachResult[0].LicenseNumber;
                                    driver.LastName = searchAllCustomerResponse.serachResult[0].LastName;
                                    driver.DriverType = MaxVonGrafKftMobileModel.Constants.DriverTypes.Additional;
                                    reservationView.CustomerDriverList.Add(driver);

                                    await Navigation.PushAsync(new SummaryOfChargesPage(reservationView));

                                }

                                else
                                {
                                    if (await DisplayAlert("No customers found", "No customers found on your details. Do you want to add a new customer as your driver?", "Yes", "Cancel"))
                                    {
                                        await Navigation.PushAsync(new AddNewDriver(reservationView, searchAllCustomerRequest.filter));
                                    }
                                    else
                                    {
                                        await Navigation.PopAsync();
                                    }

                                }
                            }
                            else
                            {
                                await PopupNavigation.PushAsync(new ErrorWithClosePagePopup(searchAllCustomerResponse.message.ErrorMessage));
                            }


                        }
                        else
                        {
                            // if (await DisplayAlert("No customers found", "No customers found on your details. Do you want to add a new customer as your driver?", "Yes", "Cancel"))
                            //{
                            //    await Navigation.PushAsync(new AddNewDriver(reservationView));
                            //}
                            await PopupNavigation.PushAsync(new ErrorWithClosePagePopup("Error in searching customers"));
                        }


                        //if (termsandConditionByTypeResponse != null)
                        //{
                        //    if (termsandConditionByTypeResponse.message.ErrorCode == "200")
                        //    {
                        //        if (termsandConditionByTypeResponse.termlist != null)
                        //        {
                        //            if (termsandConditionByTypeResponse.termlist.Count > 0)
                        //            {
                        //                //terms.Text = termsandConditionByTypeResponse.termlist[0].Term;
                        //                //tacDescription.Text = termsandConditionByTypeResponse.termlist[0].Description;
                        //                termList.ItemsSource = termsandConditionByTypeResponse.termlist;
                        //            }
                        //        }
                        //    }
                        //    else
                        //    {
                        //        await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(termsandConditionByTypeResponse.message.ErrorMessage));
                        //    }
                        //}
                    }
                }

            }
         }

        private SearchAllCustomerResponse getCustomerDetails(SearchAllCustomerRequest searchAllCustomerRequest, string token)
        {
            ReservationController reservationController = new ReservationController();
            searchAllCustomerResponse = reservationController.getCustomerDetails(searchAllCustomerRequest, token);
            return searchAllCustomerResponse;
        }
    }
}