using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Newtonsoft.Json;
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
    public partial class VehicleDetailPage : ContentPage
    {
        string token;
        int customerId;




        List<VehicleTypeResult> vehicleResults;
  //      GetVehicleDetailsMobileListResponse vehicleResponse;
        private ReservationView reservationView;
        ReservationConfigurationVehicleSearch search;

        GetReservationConfigurationMobileRequest vehicleMobileRequest;
        GetReservationConfigurationResponse vehicleMobileResponse;
        List<VehicleViewByTypeForMobile> forlistViewItemSource;

        public VehicleDetailPage(ReservationView reservationView)
        {
            InitializeComponent();
            this.reservationView = reservationView;
            search = new ReservationConfigurationVehicleSearch();
            vehicleMobileRequest = new GetReservationConfigurationMobileRequest();
            vehicleMobileResponse = null;
            search.ClientId = Constants.ClientId;
            search.LocationId =(int) reservationView.StartLocationId;
            search.CheckInLocationId = (int)reservationView.EndLocationId;
            search.IsOnline = true;
            search.StartDate = (DateTime)reservationView.StartDate;
            search.EndDate = (DateTime)reservationView.EndDate;
           
            search.VehicleCategoryId = 0;
            search.VehicleMakeID = 0;
            search.ModelId = 0;
            search.NumberOfSeats = 0;
            search.RentalPeriod = 0;
            search.VehicleId = 0;


            vehicleMobileRequest.search = search;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var assembly = typeof(BookNow);

            token = App.Current.Properties["currentToken"].ToString();
            customerId = (int)App.Current.Properties["CustomerId"];
            forlistViewItemSource = new List<VehicleViewByTypeForMobile>();


            if (customerId == 0)
            {
                loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.LogInTool.png", assembly);
            }
            else
            {
                loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logOutTool.png", assembly);
            }

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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Getting vehicles informations..."));

                    await Task.Run(() =>
                    {

                        try
                        {
                            vehicleMobileResponse = getVehicleTypesMobileNew(vehicleMobileRequest,token);
                            //vehicleResults = getVehicleTypes(token);
                            //vehicleResponse= getVehicleTypesMobile(token);


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
                }
                if (vehicleMobileResponse != null)
                {
                    if (vehicleMobileResponse.message.ErrorCode == "200")
                    {
                        if (vehicleMobileResponse.listVehicle.Count > 0)
                        {

                            List<int> vehicleTypeIds = new List<int>();

                            foreach (ReservationVehicleSearchViewModel rvsv in vehicleMobileResponse.listVehicle)
                            {
                                if (!vehicleTypeIds.Contains(rvsv.VehicleTypeId))
                                {
                                    vehicleTypeIds.Add(rvsv.VehicleTypeId);
                                    VehicleViewByTypeForMobile typeForMobile = new VehicleViewByTypeForMobile();
                                    typeForMobile.VehicleTypeId = rvsv.VehicleTypeId;
                                    typeForMobile.VehicleType = rvsv.VehicleType;
                                    typeForMobile.Transmission = rvsv.Transmission;
                                    typeForMobile.Seats = rvsv.Seats;
                                    typeForMobile.NoOfLuggage = rvsv.Baggages;
                                    typeForMobile.RateTotal = rvsv.RateDetail.RateTotal;
                                    typeForMobile.VehicleImageUrl = rvsv.VehicleImageUrl;
                                    typeForMobile.RateDetail = rvsv.RateDetail;
                                    typeForMobile.sample = rvsv.Sample;
                                    forlistViewItemSource.Add(typeForMobile);
                                }
                                else
                                {
                                    foreach (VehicleViewByTypeForMobile listIntype in forlistViewItemSource)
                                    {
                                        if (rvsv.VehicleTypeId == listIntype.VehicleTypeId)
                                        {
                                            if (rvsv.Transmission != listIntype.Transmission)
                                            {
                                                listIntype.Transmission = "Auto, Manual";
                                            }
                                        }
                                    }

                                }
                            }

                            vehicleDetailList.ItemsSource = forlistViewItemSource;
                            vehicleDetailList.HeightRequest = forlistViewItemSource.Count * 290;
                            vehicleDetailList.IsVisible = true;


                        }
                        else
                        {
                            vehicleDetailList.IsVisible = false;
                            //noVehicleLabel.IsVisible = true;
                            buttonGrid.IsVisible = true;
                            noVehicleLabel.IsVisible = true;

                        }
                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(vehicleMobileResponse.message.ErrorMessage));
                    }
                }
            }
        }

        private GetReservationConfigurationResponse getVehicleTypesMobileNew(GetReservationConfigurationMobileRequest vehicleMobileRequest, string token)
        {
            GetReservationConfigurationResponse vehicleTypeResults = null;
            VehicleController vehicle = new VehicleController();
            try
            {
                vehicleTypeResults = vehicle.getVehicleTypesMobileNew(vehicleMobileRequest,token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return vehicleTypeResults;
        }

        //private GetVehicleDetailsMobileListResponse getVehicleTypesMobile(string token)
        //{
        //    GetVehicleDetailsMobileListResponse vehicleTypeResults = null;
        //    VehicleController vehicle = new VehicleController();
        //    try
        //    {
        //        vehicleTypeResults = vehicle.getVehicleTypesMobile(token);

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return vehicleTypeResults;
        //}

        //private List<VehicleTypeResult> getVehicleTypes(string token)
        //{
        //    List<VehicleTypeResult> vehicleTypeResults = null;
        //    VehicleController vehicle = new VehicleController();
        //    try
        //    {
        //        vehicleTypeResults = vehicle.getVehicleTypes(token);
                
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return vehicleTypeResults;

        //}

        private void BacKBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void NxtBtn_Clicked(object sender, EventArgs e)
        {
            int selectedVehi = 0;
            foreach (VehicleTypeResult r in vehicleResults)
            {
                if (r.selected == true)
                {
                    selectedVehi = r.VehicleTypeId;
                }
            }
            if (selectedVehi > 0)
            {
                Navigation.PushAsync(new VehicleRates(reservationView));
            }
            else
            {
                PopupNavigation.Instance.PushAsync(new Error_popup("Please select a vehicle"));
            }

           
        }

        private async void LoginIcon_Clicked(object sender, EventArgs e)
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

        private void VehicleDetailList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //List<VehicleTypeResult> results = new List<VehicleTypeResult>();
            //VehicleTypeResult selectedVehicle = vehicleDetailList.SelectedItem as VehicleTypeResult;
            //int vehiId = selectedVehicle.VehicleTypeId;
            //foreach(VehicleTypeResult v in vehicleResults)
            //{
            //    if (v.VehicleTypeId == vehiId)
            //    {
            //        v.selected = true;
            //    }
            //    else
            //    {
            //        v.selected = false;
            //    }
            //    results.Add(v);
            //}
            //vehicleDetailList.ItemsSource = results;
            VehicleViewByTypeForMobile selectedVehicle = vehicleDetailList.SelectedItem as VehicleViewByTypeForMobile;
            reservationView.VehicleTypeID = selectedVehicle.VehicleTypeId;
            reservationView.VehicleType = selectedVehicle.VehicleType;
            Rates rates = JsonConvert.DeserializeObject<Rates>(JsonConvert.SerializeObject(selectedVehicle.RateDetail));
            rates.RateId = selectedVehicle.RateDetail.RateID;
            List<Rates> rateDewtails = new List<Rates>();
            rates.StartDateStr = reservationView.StartDateStr;
            rates.EndDateStr = reservationView.EndDateStr;
            rateDewtails.Add(rates);
            reservationView.RateDetailsList = rateDewtails;
            reservationView.TotalDays = rates.TotalDays;
            Navigation.PushAsync(new VehicleRates(reservationView));
        }

        private void VehicleDetailList_Refreshing(object sender, EventArgs e)
        {
            vehicleDetailList.ItemsSource = forlistViewItemSource;
            vehicleDetailList.HeightRequest = forlistViewItemSource.Count * 250;
            vehicleDetailList.IsVisible = true;
            vehicleDetailList.IsRefreshing = false;
        }
    }
}