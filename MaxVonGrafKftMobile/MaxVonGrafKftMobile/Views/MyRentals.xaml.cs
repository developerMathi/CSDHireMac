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
    public partial class MyRentals : ContentPage
    {
        List<CustomerAgreementModel> customerAgreementModels;
        //      GetAgreementByCustomerIdMobileResponse agreementResponse;
        getAgreementByCustomerIdMobileRequest getAgreementByCustomerIdMobileRequest;
        int customerId;
        string token;
        private List<string> filters;

        public MyRentals()
        {
            InitializeComponent();
            customerId = (int)App.Current.Properties["CustomerId"];
            token = App.Current.Properties["currentToken"].ToString();
            // agreementResponse = null;
            getAgreementByCustomerIdMobileRequest = new getAgreementByCustomerIdMobileRequest();
            getAgreementByCustomerIdMobileRequest.customerId = customerId;
            filters = new List<string>();
            filters.Add("Agreement number");
            filters.Add("Check-Out location");
            filters.Add("Check-In location");
            filters.Add("Status");
            filterPicker.ItemsSource = filters;


            var filter_tab = new TapGestureRecognizer();
            filter_tab.Tapped += (s, e) =>
            {
                filterPicker.Focus();
            };
            filterFrame.GestureRecognizers.Add(filter_tab);
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


            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Loading my rentals.."));

                    await Task.Run(async () =>
                    {
                        try
                        {
                            //agreementResponse = getAgreementMobile(getAgreementByCustomerIdMobileRequest, token);
                            //customerAgreementModels = agreementResponse.listAgreements;
                            customerAgreementModels = getReservations(customerId, token);
                        }
                        catch (Exception ex)
                        {
                            await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(ex.Message));
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
                    else if (PopupNavigation.Instance.PopupStack.Count > 1)
                    {
                        if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup))
                        {
                            await PopupNavigation.Instance.PopAllAsync();
                        }
                    }
                }
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }


                        myRentalsList.ItemsSource = agreementItemSource;
                        myRentalsList.HeightRequest = 220 * customerAgreementModels.Count;
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
                else
                {
                    myRentalsList.IsVisible = false;
                    emptyMyrentals.IsVisible = true;
                }
            }
        }

        private GetAgreementByCustomerIdMobileResponse getAgreementMobile(getAgreementByCustomerIdMobileRequest getAgreementByCustomerIdMobileRequest, string token)
        {
            AgreementController agreementController = new AgreementController();
            GetAgreementByCustomerIdMobileResponse response;
            try
            {
                response = agreementController.getAgreementMobile(getAgreementByCustomerIdMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        private List<CustomerAgreementModel> getReservations(int customerId, string token)
        {
            RegisterController registerController = new RegisterController();
            List<CustomerAgreementModel> agreementModels = null;
            try
            {
                agreementModels = registerController.getAgreements(customerId, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return agreementModels;
        }

        private void MyRentalsList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CustomerAgreementModel agreementModel = myRentalsList.SelectedItem as CustomerAgreementModel;
            ((ListView)sender).SelectedItem = null;
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(ViewMyRental))
            {
                Navigation.PushAsync(new ViewMyRental(agreementModel.AgreementId));
            }
        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(HomePage))
            {
                Navigation.PushAsync(new HomePage());
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            myRentalsList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }


                        myRentalsList.ItemsSource = agreementItemSource;
                        myRentalsList.HeightRequest = 220 * customerAgreementModels.Count;
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }
            else
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }

                        myRentalsList.ItemsSource = agreementItemSource.Where(i => i.AgreementNumber.ToLower().Contains(e.NewTextValue.ToLower()));
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }


            myRentalsList.EndRefresh();
            int rowcounter = 0;
            foreach (var item in myRentalsList.ItemsSource)
            {
                rowcounter++;
            }
            myRentalsList.HeightRequest = 220 * rowcounter;
            //List<CustomerAgreementModel> models = new List<CustomerAgreementModel>();
            //models = myRentalsList.ItemsSource as List<CustomerAgreementModel>;
            //if(models != null)
            //{
            //    if (models.Count > 0)
            //    {
            //        myRentalsList.HeightRequest = 220 * models.Count;
            //    }
            //}
        }

        private void SearchBar_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            myRentalsList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }


                        myRentalsList.ItemsSource = agreementItemSource;
                        myRentalsList.HeightRequest = 220 * customerAgreementModels.Count;
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }
            else
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }

                        myRentalsList.ItemsSource = agreementItemSource.Where(i => i.CheckoutLocation.ToLower().Contains(e.NewTextValue.ToLower()));
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }


            myRentalsList.EndRefresh();
            int rowcounter = 0;
            foreach (var item in myRentalsList.ItemsSource)
            {
                rowcounter++;
            }
            myRentalsList.HeightRequest = 220 * rowcounter;
            //List<CustomerAgreementModel> models = new List<CustomerAgreementModel>();
            //models = myRentalsList.ItemsSource as List<CustomerAgreementModel>;
            //if(models != null)
            //{
            //    if (models.Count > 0)
            //    {
            //        myRentalsList.HeightRequest = 220 * models.Count;
            //    }
            //}
        }

        private void SearchBar_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            myRentalsList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }


                        myRentalsList.ItemsSource = agreementItemSource;
                        myRentalsList.HeightRequest = 220 * customerAgreementModels.Count;
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }
            else
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }

                        myRentalsList.ItemsSource = agreementItemSource.Where(i => i.CheckinLocation.ToLower().Contains(e.NewTextValue.ToLower()));
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }


            myRentalsList.EndRefresh();
            int rowcounter = 0;
            foreach (var item in myRentalsList.ItemsSource)
            {
                rowcounter++;
            }
            myRentalsList.HeightRequest = 220 * rowcounter;
            //List<CustomerAgreementModel> models = new List<CustomerAgreementModel>();
            //models = myRentalsList.ItemsSource as List<CustomerAgreementModel>;
            //if(models != null)
            //{
            //    if (models.Count > 0)
            //    {
            //        myRentalsList.HeightRequest = 220 * models.Count;
            //    }
            //}
        }

        private void SearchBar_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            myRentalsList.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }


                        myRentalsList.ItemsSource = agreementItemSource;
                        myRentalsList.HeightRequest = 220 * customerAgreementModels.Count;
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }
            else
            {
                if (customerAgreementModels != null)
                {
                    if (customerAgreementModels.Count > 0)
                    {
                        List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                        for (int i = customerAgreementModels.Count - 1; i >= 0; i--)
                        {
                            agreementItemSource.Add(customerAgreementModels[i]);
                        }

                        myRentalsList.ItemsSource = agreementItemSource.Where(i => i.Status.ToLower().Contains(e.NewTextValue.ToLower()));
                    }
                    else
                    {
                        myRentalsList.IsVisible = false;
                        emptyMyrentals.IsVisible = true;
                    }
                }
            }


            myRentalsList.EndRefresh();
            int rowcounter = 0;
            foreach (var item in myRentalsList.ItemsSource)
            {
                rowcounter++;
            }
            myRentalsList.HeightRequest = 220 * rowcounter;
            //List<CustomerAgreementModel> models = new List<CustomerAgreementModel>();
            //models = myRentalsList.ItemsSource as List<CustomerAgreementModel>;
            //if(models != null)
            //{
            //    if (models.Count > 0)
            //    {
            //        myRentalsList.HeightRequest = 220 * models.Count;
            //    }
            //}
        }

        private void filterPicker_Unfocused(object sender, FocusEventArgs e)
        {
            if (filterPicker.SelectedItem != null)
            {
                if (filterPicker.SelectedItem.ToString() == "Agreement number")
                {
                    checkoutLocationSearchBar.IsVisible = false;
                    checkinLocationSearchBar.IsVisible = false;
                    statusSearchBar.IsVisible = false;
                    numberSearchBar.IsVisible = true;
                }
                if (filterPicker.SelectedItem.ToString() == "Check-Out location")
                {
                    checkinLocationSearchBar.IsVisible = false;
                    statusSearchBar.IsVisible = false;
                    numberSearchBar.IsVisible = false;
                    checkoutLocationSearchBar.IsVisible = true;

                }
                if (filterPicker.SelectedItem.ToString() == "Check-In location")
                {
                    statusSearchBar.IsVisible = false;
                    numberSearchBar.IsVisible = false;
                    checkoutLocationSearchBar.IsVisible = false;
                    checkinLocationSearchBar.IsVisible = true;
                }
                if (filterPicker.SelectedItem.ToString() == "Status")
                {
                    numberSearchBar.IsVisible = false;
                    checkoutLocationSearchBar.IsVisible = false;
                    checkinLocationSearchBar.IsVisible = false;
                    statusSearchBar.IsVisible = true;
                }
            }
        }
    }
}