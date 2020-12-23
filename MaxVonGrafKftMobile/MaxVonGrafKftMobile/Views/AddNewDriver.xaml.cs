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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddNewDriver : ContentPage
    {
        string _token;
        GetAllCountryForMobileResponse countryResponse = null;
        GetAllStateForMobileResponse stateResponse = null;
        private ReservationView reservationView;
        private CustomerReview customer;
        private int customerID;
        private CustomerSerach filter;

        public AddNewDriver(ReservationView reservationView, CustomerSerach filter)
        {
            InitializeComponent();
            customer = new CustomerReview();
            this.filter = filter;
            customerID = 0;
            this.reservationView = reservationView;
            _token = App.Current.Properties["currentToken"].ToString();

            DateOfBithEntry.MaximumDate = DateTime.Now.AddYears(-18);
            countryResponse = getAllCountry(_token);
            List<string> countryList = new List<string>();
            if (countryResponse.countryList.Count > 0) { foreach (Country k in countryResponse.countryList) { countryList.Add(k.CountryName); }; }
            countryPicker.ItemsSource = countryList;

            if (Constants.admin != null)
            {
                if (Constants.admin.CountryId > 0)
                {
                    if (Constants.countriesHasState.Contains(Constants.admin.CountryId))
                    {
                        statePicker.Title = "State";
                    };

                    string cliCountry = returnCountryNameByID(Constants.admin.CountryId);
                    if (cliCountry != null)
                    {
                        countryPicker.SelectedItem = cliCountry;
                    }
                }
            }
            else
            {
                countryPicker.SelectedItem = "USA";
            }
            List<string> stateList = new List<string>();
            int? counid = null;
            foreach (Country c in countryResponse.countryList) { if (c.CountryName == countryPicker.SelectedItem.ToString()) { counid = c.CountryId; } };

            if (counid != null)
            {
                GetAllStateForMobileRequest stateRequest = new GetAllStateForMobileRequest();
                stateRequest.CountryID = counid.Value;
                stateResponse = getStates(stateRequest, _token);
                if (stateResponse.stateList.Count > 0) { foreach (State s in stateResponse.stateList) { stateList.Add(s.StateName); }; }
                statePicker.ItemsSource = stateList;
            }
        }

        protected override async void OnAppearing()
        {


            base.OnAppearing();
            if (filter != null)
            {
                FnameEntry.Text = filter.FirstName;
                LnameEntry.Text = filter.LastName;
                phoneEntry.Text = filter.hPhone;
            }

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


        private void countryPicker_Unfocused(object sender, FocusEventArgs e)
        {
            if (countryPicker.SelectedIndex != -1)
            {
                string countryName = countryPicker.SelectedItem.ToString();
                List<string> stateList = new List<string>();
                int? counid = null;
                foreach (Country c in countryResponse.countryList) { if (c.CountryName == countryName) { counid = c.CountryId; } };

                if (counid != null)
                {
                    GetAllStateForMobileRequest stateRequest = new GetAllStateForMobileRequest();
                    stateRequest.CountryID = counid.Value;
                    stateResponse = getStates(stateRequest, _token);
                    if (stateResponse.stateList.Count > 0) { foreach (State s in stateResponse.stateList) { stateList.Add(s.StateName); }; }
                    statePicker.ItemsSource = stateList;
                }

            }
        }

        private GetAllCountryForMobileResponse getAllCountry(string access_token)
        {
            CommonController commonControllerCountry = new CommonController();
            GetAllCountryForMobileResponse countryResponse;
            countryResponse = commonControllerCountry.GetAllCountry(access_token);
            return countryResponse;
        }

        private GetAllStateForMobileResponse getStates(GetAllStateForMobileRequest stateRequest, string token)
        {
            CommonController stateController = new CommonController();
            GetAllStateForMobileResponse sResponse;
            sResponse = stateController.GetAllStateByCountryID(stateRequest, token);
            return sResponse;
        }

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
            else if (string.IsNullOrEmpty(phoneEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter phone number."));
            }
            else if (phoneEntry.Text.Length < 10)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid phone number."));
            }
            else if (string.IsNullOrEmpty(addresssEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your address."));
            }
            else if (string.IsNullOrEmpty(cityEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your city name."));
            }
            else if (countryPicker.SelectedIndex == -1)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please select your country"));
            }
            else if (statePicker.SelectedIndex == -1)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please select your state"));
            }
            else if (string.IsNullOrEmpty(emailEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your Email address"));

            }
            else if (!new EmailAddressAttribute().IsValid(emailEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid Email address"));
            }
            else if (DateOfBithEntry.Date == null)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Plese select your date of birth"));
            }
            else if (DateOfBithEntry.Date.AddYears(18).AddDays(1) > DateTime.Now)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Your Age should be above 18 Years."));
            }
            else if (string.IsNullOrEmpty(licNoEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your licence number"));

            }

            else
            {
                customer.CustomerType = "Retail";
                customer.ClientId = Constants.ClientId;
                customer.Password = "123";
                customer.FirstName = FnameEntry.Text;
                customer.LastName = LnameEntry.Text;
                customer.Address1 = addresssEntry.Text;
                customer.City = cityEntry.Text;
                customer.CountryId = returnCountryIdByCountryName(countryPicker.SelectedItem.ToString());
                customer.CountryName = countryPicker.SelectedItem.ToString();
                customer.StateId = returnStateIdByStateName(statePicker.SelectedItem.ToString());
                customer.StateName = statePicker.SelectedItem.ToString();
                customer.hPhone = phoneEntry.Text;
                customer.Email = emailEntry.Text;
                customer.LicenseNumber = licNoEntry.Text;
                customer.DateOfbirth = DateOfBithEntry.Date;

                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        await PopupNavigation.Instance.PushAsync(new LoadingPopup("Saving your informations"));
                        await Task.Run(() =>
                        {


                            RegisterController registerController = new RegisterController();
                            customerID = registerController.registerUser(customer, _token);

                        });
                    }
                    finally
                    {
                        busy = false;
                        await PopupNavigation.Instance.PopAllAsync();
                        if (customerID > 0)
                        {
                            Driver driver = new Driver();
                            driver.FirstName = FnameEntry.Text;
                            driver.LastName = LnameEntry.Text;

                            driver.CustomerId = customerID;
                            driver.hPhone = phoneEntry.Text;
                            driver.Address1 = addresssEntry.Text;
                            driver.StateId = returnStateIdByStateName(statePicker.SelectedItem.ToString());
                            driver.CountryId = returnCountryIdByCountryName(countryPicker.SelectedItem.ToString());
                            driver.Email = emailEntry.Text;
                            driver.DriverType = MaxVonGrafKftMobileModel.Constants.DriverTypes.Additional;
                            driver.City = cityEntry.Text;
                            driver.DateofBirth = DateOfBithEntry.Date;
                            driver.DriverLicenseNumber = licNoEntry.Text;
                            reservationView.CustomerDriverList.Add(driver);

                            await Navigation.PushAsync(new SummaryOfChargesPage(reservationView));
                        }
                        else
                        {
                            emailEntry.Text = null;
                            phoneEntry.Text = null;
                            await PopupNavigation.Instance.PushAsync(new Error_popup("Customer creation failed. please check your details once again."));

                        }
                    }
                }
            }
            
        }

        private void backBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SummaryOfChargesPage(reservationView));
        }

        private int? returnStateIdByStateName(string v)
        {
            int staID = 0;
            foreach (State p in stateResponse.stateList) { if (p.StateName == v) { staID = p.StateID; } }
            return staID;
        }

        private int? returnCountryIdByCountryName(string v)
        {
            int? cntryId = null;
            foreach (Country o in countryResponse.countryList) { if (o.CountryName == v) { cntryId = o.CountryId; } }
            return cntryId.Value;
        }

        private string returnCountryNameByID(int? id)
        {
            string counName = null;
            foreach (Country o in countryResponse.countryList) { if (o.CountryId == id) { counName = o.CountryName; } }
            return counName;
        }


    }
}