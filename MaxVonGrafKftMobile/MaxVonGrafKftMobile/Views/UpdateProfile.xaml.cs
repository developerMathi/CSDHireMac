using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class UpdateProfile : ContentPage
    {
        string _token;
        GetAllCountryForMobileResponse countryResponse;
        GetAllStateForMobileResponse stateResponse;
        private CustomerReview customerReview;
        UpdateCustomerProfileDetailsMobileRequest ProfileDetailsMobileRequest;
        UpdateCustomerProfileDetailsMobileResponse profileDetailsMobileResponse;
        GetCustomerPortalDetailsMobileRequest portalDetailsMobileRequest;
        GetCustomerPortalDetailsMobileResponse PortalDetailsMobileResponse;
        int customerId;
        CustomerController customoerController;
        static CustomerImages Images;

        [Obsolete]
        public UpdateProfile(CustomerReview customerReview)
        {
            InitializeComponent();
            this.customerReview = customerReview;
            _token = App.Current.Properties["currentToken"].ToString();
            customerId = (int)Application.Current.Properties["CustomerId"];
            countryResponse = null;
            stateResponse = null;
            ProfileDetailsMobileRequest = new UpdateCustomerProfileDetailsMobileRequest();
            profileDetailsMobileResponse = null;
            portalDetailsMobileRequest = new GetCustomerPortalDetailsMobileRequest();
            portalDetailsMobileRequest.customerId = customerId;
            PortalDetailsMobileResponse = null;
            customoerController = new CustomerController();
            Images = null;

            var editPhoto = new TapGestureRecognizer();
            editPhoto.Tapped += (s, e) =>
            {
                if (Images != null)
                {
                    if (Images.Base64 == null)
                    {
                        PopupNavigation.PushAsync(new editPrrofilePhotoPage());
                    }
                    else
                    {

                        PopupNavigation.PushAsync(new editPrrofilePhotoPage(Images));
                    }
                }
                else
                {
                    PopupNavigation.PushAsync(new editPrrofilePhotoPage());
                }

            };
            profileImage.GestureRecognizers.Add(editPhoto);
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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Loading details..."));

                    await Task.Run(() =>
                    {

                        try
                        {
                            countryResponse = getAllCountry(_token);
                            PortalDetailsMobileResponse = getCustomerDetailsWithProfilePic(portalDetailsMobileRequest, _token);

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
                    else if (PopupNavigation.Instance.PopupStack.Count > 1)
                    {
                        if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 2].GetType() == typeof(editPrrofilePhotoPage))
                        {
                            await PopupNavigation.Instance.PopAsync();
                        }

                        else if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup))
                        {
                            await PopupNavigation.Instance.PopAllAsync();
                        }
                    }
                }
                List<string> countryList = new List<string>();
                if (countryResponse.countryList.Count > 0) { foreach (Country k in countryResponse.countryList) { countryList.Add(k.CountryName); }; }
                countryPicker.ItemsSource = countryList;
                FirstNameEntry.Text = customerReview.FirstName;
                LastNameEntry.Text = customerReview.LastName;
                AddressEntry.Text = customerReview.Address1 + " " + customerReview.Address2;
                CityEntry.Text = customerReview.City;
                countryPicker.SelectedItem = customerReview.CountryName;
                if (PortalDetailsMobileResponse.customerReview != null )
                {
                    if (PortalDetailsMobileResponse.customerReview.CustomerImages.Count > 0)
                    {
                        if (PortalDetailsMobileResponse.customerReview.CustomerImages[PortalDetailsMobileResponse.customerReview.CustomerImages.Count - 1].Base64 != null)
                        {
                            Images = PortalDetailsMobileResponse.customerReview.CustomerImages[PortalDetailsMobileResponse.customerReview.CustomerImages.Count - 1];
                            byte[] Base64Stream = Convert.FromBase64String(PortalDetailsMobileResponse.customerReview.CustomerImages[PortalDetailsMobileResponse.customerReview.CustomerImages.Count - 1].Base64);
                            profileImage.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
                        }
                    }
                }

                string countryName = customerReview.CountryName;
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

                statePicker.SelectedItem = customerReview.StateName;
                PostalCodeEntry.Text = customerReview.ZipCode;
                ContactNoEntry.Text = customerReview.hPhone;




            }
        }

        private GetCustomerPortalDetailsMobileResponse getCustomerDetailsWithProfilePic(GetCustomerPortalDetailsMobileRequest portalDetailsMobileRequest, string token)
        {
            GetCustomerPortalDetailsMobileResponse response = new GetCustomerPortalDetailsMobileResponse();
            try
            {
                response = customoerController.getCustomerDetailsWithProfilePic(portalDetailsMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        private async void UpdateBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a first name."));
            }
            else if (string.IsNullOrEmpty(LastNameEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a last name."));
            }
            else if (string.IsNullOrEmpty(AddressEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your address."));
            }
            else if (string.IsNullOrEmpty(CityEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your city."));
            }
            else if (countryPicker.SelectedIndex == -1)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please select your country"));
            }
            else if (statePicker.SelectedIndex == -1)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please select your state"));
            }
            else if (string.IsNullOrEmpty(PostalCodeEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your postal code."));
            }
            else if (string.IsNullOrEmpty(ContactNoEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your contactNo."));
            }
            else
            {
                customerReview.FirstName = FirstNameEntry.Text;
                customerReview.LastName = LastNameEntry.Text;
                customerReview.Address1 = AddressEntry.Text;
                customerReview.City = CityEntry.Text;
                customerReview.CountryId = returnCountryIdByCountryName(countryPicker.SelectedItem.ToString());
                customerReview.CountryName = countryPicker.SelectedItem.ToString();
                customerReview.StateId = returnStateIdByStateName(statePicker.SelectedItem.ToString());
                customerReview.StateName = statePicker.SelectedItem.ToString();
                customerReview.ZipCode = PostalCodeEntry.Text;
                customerReview.hPhone = ContactNoEntry.Text;
                customerReview.ClientId = Constants.ClientId;
                ProfileDetailsMobileRequest.custReview = customerReview;


                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        await PopupNavigation.Instance.PushAsync(new LoadingPopup("Updating your informations"));
                        await Task.Run(() =>
                        {
                            RegisterController registerController = new RegisterController();

                            try
                            {
                                profileDetailsMobileResponse = registerController.updateUser(ProfileDetailsMobileRequest, _token);


                            }
                            catch (Exception ex)
                            {
                                PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(ex.Message));
                            }

                        });
                        if (profileDetailsMobileResponse != null)
                        {
                            if (profileDetailsMobileResponse.message.ErrorCode == "200")
                            {
                                await PopupNavigation.Instance.PushAsync(new SuccessWithClosePopup("Profile updated successfully"));
                            }
                        }
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
                            if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup) && PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(SuccessWithClosePopup))
                            {
                                await PopupNavigation.Instance.PopAllAsync();
                            }
                        }
                    }


                }
            }
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

        private GetAllCountryForMobileResponse getAllCountry(string access_token)
        {
            CommonController commonControllerCountry = new CommonController();
            GetAllCountryForMobileResponse countryResponse;
            countryResponse = commonControllerCountry.GetAllCountry(access_token);
            return countryResponse;
        }

        private void CountryPicker_Unfocused(object sender, FocusEventArgs e)
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
        private GetAllStateForMobileResponse getStates(GetAllStateForMobileRequest stateRequest, string token)
        {
            CommonController stateController = new CommonController();
            GetAllStateForMobileResponse sResponse;
            sResponse = stateController.GetAllStateByCountryID(stateRequest, token);
            return sResponse;
        }
    }
}