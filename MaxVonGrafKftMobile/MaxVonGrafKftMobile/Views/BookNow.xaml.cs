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
    public partial class BookNow : ContentPage
    {
        private string _token;
        //List<LocationModel> locationModels;
        GetAllLocationForClientIDForMobileResponse locationResponse;
        GetStoreHoursMobileRequest getStoreHoursMobileRequest;
        GetStoreHoursMobileResponse getStoreHoursMobileResponse;
        List<string> locationNames;
        ReservationView reservationView;



        public BookNow()
        {
            InitializeComponent();
            //locationModels = null;
            locationResponse = null;
            getStoreHoursMobileResponse = null;
            getStoreHoursMobileRequest = new GetStoreHoursMobileRequest();
            reservationView = new ReservationView();

        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var assembly = typeof(BookNow);

            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ErrorWithClosePagePopup))
                {
                    await PopupNavigation.Instance.PopAllAsync();
                }
            }


            _token = App.Current.Properties["currentToken"].ToString();

            if ((int)App.Current.Properties["CustomerId"] == 0)
            {
                loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.LogInTool.png", assembly);
            }
            else
            {
                loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logOutTool.png", assembly);
            }
            GetAllLocationForClientIDForMobileRequest locationRequest = new GetAllLocationForClientIDForMobileRequest();
            locationRequest.ClientID = Constants.ClientId;


            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Creating book now page..."));

                    await Task.Run(async () =>
                    {
                        try
                        {

                            locationResponse = getAllLocationsByClientId(locationRequest, _token);
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
                if (locationResponse != null)
                {
                    locationNames = new List<string>();
                    foreach (LocationModel l in locationResponse.locationList)
                    {
                        if ((bool)l.Active)
                        {
                            locationNames.Add(l.LocationName);
                        }

                    }
                    pickUpLocation.ItemsSource = locationNames;
                    dropOffLocation.ItemsSource = locationNames;
                    pickUpLocation.SelectedIndex = 0;
                    dropOffLocation.SelectedIndex = 0;
                }
                else
                {
                    await Navigation.PopAsync();
                }


                pickUpDate.MinimumDate = DateTime.Now;
                pickUpDate.Date = DateTime.Now;
                pickUpTime.Time = new TimeSpan(9, 0, 0);
                dropOffDate.Date = DateTime.Now.AddDays(1);
                dropOffDate.MinimumDate = DateTime.Now;
                dropOffTime.Time = new TimeSpan(9, 0, 0);
            }
        }

        private GetAllLocationForClientIDForMobileResponse getAllLocationsByClientId(GetAllLocationForClientIDForMobileRequest locationRequest, string _token)
        {
            CommonController commoncontroller = new CommonController();
            GetAllLocationForClientIDForMobileResponse locations = null;
            try

            {
                locations = commoncontroller.getAllLocationsByClientId(locationRequest, _token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return locations;
        }

        private void BookNowNxtBtn_Clicked(object sender, EventArgs e)
        {
            DateTime pickupDateTime = pickUpDate.Date + pickUpTime.Time;
            DateTime DropOffDateTime = dropOffDate.Date + dropOffTime.Time;

            int result = DateTime.Compare(pickupDateTime, DropOffDateTime);
            if (pickupDateTime < DateTime.Now)
            {
                PopupNavigation.Instance.PushAsync(new Error_popup("Plese check your pick-up time."));
            }
            else if (result > 0 || result == 0)
            {
                PopupNavigation.Instance.PushAsync(new Error_popup("Invalid drop-off time"));
            }
            else if (pickUpLocation.SelectedIndex == -1)
            {
                PopupNavigation.Instance.PushAsync(new Error_popup("Please select a pick-up location"));
            }
            else if (dropOffLocation.SelectedIndex == -1)
            {
                PopupNavigation.Instance.PushAsync(new Error_popup("Please select a drop-off location"));
            }

            else
            {

                int locId = getLocationIdByName(pickUpLocation.SelectedItem.ToString());
                getStoreHoursMobileRequest.locationId = locId;
                try
                {
                    ReservationController reservationController = new ReservationController();
                    getStoreHoursMobileResponse = reservationController.getStoreHoursMobile(getStoreHoursMobileRequest, _token);
                }
                catch (Exception ex)
                {
                    PopupNavigation.Instance.PushAsync(new Error_popup(ex.Message));
                }
                if (getStoreHoursMobileResponse != null)
                {
                    if (getStoreHoursMobileResponse.storeHourModels != null)
                    {
                        if (getStoreHoursMobileResponse.storeHourModels.Count > 0)
                        {
                            bool isPickUpStoreTime = true;
                            bool isDropOffStoreTime = true;
                            bool isPickUpNonHoliday = true;
                            bool isDropOffNonHoliday = true;
                            DayOfWeek date = (pickUpDate.Date + pickUpTime.Time).DayOfWeek;
                            DayOfWeek datedeliver = (dropOffDate.Date + dropOffTime.Time).DayOfWeek;

                            foreach (SearchStoreHourModel sshm in getStoreHoursMobileResponse.storeHourModels)
                            {

                                if ((pickUpDate.Date + pickUpTime.Time).DayOfWeek.ToString() == Enum.GetName(typeof(DayOfWeek), sshm.Day - 1))
                                {
                                    if (((DateTime)sshm.StartTime).TimeOfDay <= pickUpTime.Time && pickUpTime.Time <= ((DateTime)sshm.EndTime).TimeOfDay)
                                    {
                                        if (sshm.IsHoliday)
                                        {
                                            isPickUpNonHoliday = false;
                                            PopupNavigation.Instance.PushAsync(new Error_popup("Sorry,your pick up date is a holiday. please choose another pickup date"));
                                        }
                                        else
                                        {
                                            isPickUpNonHoliday = true;
                                            isPickUpStoreTime = true;
                                        }
                                    }
                                    else
                                    {
                                        isPickUpStoreTime = false;
                                        PopupNavigation.Instance.PushAsync(new Error_popup("Sorry, we are only open during " + sshm.StartTimeStr + " to " + sshm.EndTimeStr + " Please select a different pick up time"));
                                    }
                                }


                                if ((dropOffDate.Date + dropOffTime.Time).DayOfWeek.ToString() == Enum.GetName(typeof(DayOfWeek), sshm.Day - 1))
                                {
                                    if (((DateTime)sshm.StartTime).TimeOfDay <= dropOffTime.Time && dropOffTime.Time <= ((DateTime)sshm.EndTime).TimeOfDay)
                                    {

                                        if (sshm.IsHoliday)
                                        {
                                            isDropOffNonHoliday = false;
                                            PopupNavigation.Instance.PushAsync(new Error_popup("Sorry,your drop off date is a holiday. please choose another Drop-off date"));
                                        }
                                        else
                                        {
                                            isDropOffNonHoliday = true;
                                            isDropOffStoreTime = true;
                                        }
                                    }
                                    else
                                    {
                                        isDropOffStoreTime = false;
                                        PopupNavigation.Instance.PushAsync(new Error_popup("Sorry, we are only open during " + sshm.StartTimeStr + " to " + sshm.EndTimeStr + " Please select a different drop off time"));
                                    }
                                }

                            }
                            if (isPickUpStoreTime && isDropOffStoreTime && isPickUpNonHoliday && isDropOffNonHoliday)
                            {
                                navigateNextPage();
                            }
                        }
                        else
                        {
                            navigateNextPage();
                        }
                    }
                    else
                    {
                        navigateNextPage();
                    }
                }
                else
                {
                    navigateNextPage();
                }
            }
        }

        private void navigateNextPage()
        {

            reservationView.StartLocationName = pickUpLocation.SelectedItem.ToString();
            reservationView.EndLocationName = dropOffLocation.SelectedItem.ToString();
            reservationView.StartLocationId = getLocationIdByName(pickUpLocation.SelectedItem.ToString());
            reservationView.EndLocationId = getLocationIdByName(dropOffLocation.SelectedItem.ToString());
            reservationView.StartDate = pickUpDate.Date + pickUpTime.Time;
            reservationView.EndDate = dropOffDate.Date + dropOffTime.Time;
            reservationView.StartDateStr = ((DateTime)reservationView.StartDate).ToString("MM/dd/yyyy hh:mm tt").Replace("-", "/");
            reservationView.EndDateStr = ((DateTime)reservationView.EndDate).ToString("MM/dd/yyyy hh:mm tt").Replace("-", "/"); ;

            DateTime sDate = pickUpDate.Date + pickUpTime.Time;
            DateTime eDate = dropOffDate.Date + dropOffTime.Time;
            //reservationView.TotalDays =(int)((eDate - sDate).TotalDays);
            reservationView.ClientId = Constants.ClientId;
            Navigation.PushAsync(new VehicleDetailPage(reservationView));
        }



        private int getLocationIdByName(string v)
        {
            int locationId = 0;
            foreach (LocationModel l in locationResponse.locationList)
            {
                if (l.LocationName == v)
                {
                    locationId = (int)l.LocationId;
                }
            }
            return locationId;
        }

        //public List<LocationModel> GetAllLocation()
        //{
        //    CommonController commoncontroller = new CommonController();
        //    List<LocationModel> locations = commoncontroller.GetAllLocation(_token);
        //    return locations;
        //}

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var assembly = typeof(BookNow);
            if ((int)App.Current.Properties["CustomerId"] == 0)
            {
                loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logOutTool.png", assembly);
                await Navigation.PushAsync(new LoginPage());
            }
            else
            {
                bool logout = await DisplayAlert("Alert", "Are you sure want to logout", "Yes", "No");
                if (logout)
                {
                    App.Current.Properties["CustomerId"] = 0;
                    loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.LogInTool.png", assembly);
                    await Navigation.PushAsync(new WelcomPage());
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

        private void PickUpDate_Unfocused(object sender, FocusEventArgs e)
        {
            if (pickUpDate.Date != null)
            {
                dropOffDate.Date = pickUpDate.Date.AddDays(1);
                dropOffDate.MinimumDate = pickUpDate.Date;
            }
        }

        private void PickUpDate_Unfocused_1(object sender, FocusEventArgs e)
        {

        }

        private void backBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void pickUpLocation_Unfocused(object sender, FocusEventArgs e)
        {
            if (pickUpLocation.SelectedIndex != -1)
            {
                dropOffLocation.SelectedIndex = pickUpLocation.SelectedIndex;
            }
        }
    }
}