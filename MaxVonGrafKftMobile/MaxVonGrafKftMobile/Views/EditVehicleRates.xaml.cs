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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditVehicleRates : ContentPage
    {
        //MisChargeFilter misChargeFilter;
        GetMischargeSearchDetailsMobileRequest misChargeRequest;
        //TaxFilter taxFilter;
        GetTaxMobileListRequest taxRequest;
        GetPromotionMobileRequest promotionMobileRequest;
        GetPromotionMobileResponse promotionMobileResponse;
        IEnumerable<MischargeResultMobile> misChargeResults;
        GetMischargeSearchDetailsMobileResponse misChargeResponse;
        List<LocationTaxModel> taxResults;
        GetTaxMobileListResponse taxResponse;
        ReservationController reservationController;
        string token;
        private ReservationView reservationView;
        private ReservationViewModel reservationData;

        

        public EditVehicleRates(ReservationView reservationView, ReservationViewModel reservationData) 
        {
            InitializeComponent();
            this.reservationView = reservationView;
            //misChargeFilter = new MisChargeFilter();
            misChargeRequest = new GetMischargeSearchDetailsMobileRequest();
            //taxFilter = new TaxFilter();
            taxRequest = new GetTaxMobileListRequest();
            promotionMobileRequest = new GetPromotionMobileRequest();
            //misChargeFilter.LocationId =(int) reservationView.StartLocationId;
            //misChargeFilter.VehicleTypeId =(int) reservationView.VehicleTypeID;
            misChargeRequest.LocationId = (int)reservationView.StartLocationId;
            misChargeRequest.VehicleTypeId = (int)reservationView.VehicleTypeID;
            //taxFilter.LocationId = (int)reservationView.StartLocationId;
            taxRequest.LocationId = (int)reservationView.StartLocationId;
            promotionMobileResponse = null;
            misChargeResults = null;
            misChargeResponse = null;
            taxResults = null;
            taxResponse = null;
            reservationController = new ReservationController();
            token = App.Current.Properties["currentToken"].ToString();
            this.reservationData = reservationData;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var assembly = typeof(VehicleRates);
            if ((int)App.Current.Properties["CustomerId"] == 0)
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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Getting vehicles rates..."));

                    await Task.Run(() =>
                    {
                        try
                        {
                            //misChargeResults = reservationController.getMisCharge(misChargeFilter,token);
                            misChargeResponse = reservationController.getMisChargeMobile(misChargeRequest, token);
                            //taxResults = reservationController.getTax(taxFilter,token);
                            taxResponse = reservationController.GetTaxMobileList(taxRequest, token);



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


                    if (taxResponse.message.ErrorCode == "200")
                    {
                        taxResults = taxResponse.LocationTaxResult;
                        foreach (LocationTaxModel t in taxResults)
                        {
                            if (t.IsOption)
                            {
                                t.IsSelected = false;
                                if (reservationView.TaxList2 != null)
                                {
                                    if (reservationView.TaxList2.Count > 0)
                                    {
                                        foreach (LocationTaxModel ltm in reservationView.TaxList2)
                                        {
                                            if (ltm.TaxId == t.TaxId)
                                            {
                                                t.IsSelected = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                t.IsSelected = true;
                            }

                        }
                    };
                    if (taxResponse.message.ErrorCode != "200")
                    {
                        await PopupNavigation.Instance.PushAsync(new Error_popup(taxResponse.message.ErrorMessage));
                    };


                    if (misChargeResponse.message.ErrorCode == "200")
                    {
                        misChargeResults = misChargeResponse.MiscResult;
                        foreach (MischargeResultMobile m in misChargeResults)
                        {
                            if (!m.IsOptional)
                            {
                                m.isSelected = false;
                                if (reservationView.MiscList2 != null)
                                {
                                    if (reservationView.MiscList2.Count > 0)
                                    {
                                        foreach (MiscChargeSearchReview msv in reservationView.MiscList2)
                                        {
                                            if (msv.MiscChargeID == m.MiscChargeID)
                                            {
                                                m.isSelected = true;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                m.isSelected = true;
                            }
                        }
                    };
                    if (misChargeResponse.message.ErrorCode != "200")
                    {
                        await PopupNavigation.Instance.PushAsync(new Error_popup(misChargeResponse.message.ErrorMessage));
                    };


                    if (misChargeResults.Count() > 0)
                    {
                        RateList.ItemsSource = misChargeResults;
                        RateList.HeightRequest = (misChargeResults.Count() * 42) + 50;
                    }
                    if (misChargeResults.Count() == 0)
                    {
                        RateList.IsVisible = false;
                    }


                    if (taxResults.Count() > 0)
                    {
                        taxList.ItemsSource = taxResults;
                        taxList.HeightRequest = (taxResults.Count() * 42) + 50;
                    }
                    if (taxResults.Count() == 0)
                    {
                        taxList.IsVisible = false;
                    }


                }

            }



        }

        private async void LoginIcon_Clicked(object sender, EventArgs e)
        {
            var assembly = typeof(VehicleRates);
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

        private void BacKBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void NxtBtn_Clicked(object sender, EventArgs e)
        {
            if (misChargeResults.Count() > 0)
            {
                List<MiscChargeSearchReview> miscChargeSearchReviews = new List<MiscChargeSearchReview>();
                List<MischargeResultMobile> itemListMis = RateList.ItemsSource as List<MischargeResultMobile>;
                foreach (MischargeResultMobile msr in itemListMis)
                {
                    MiscChargeSearchReview miscChargeSearchReview = new MiscChargeSearchReview();
                    miscChargeSearchReview.VehicleTypeId = msr.VehicleTypeId;
                    miscChargeSearchReview.LocationId = msr.LocationId;
                    miscChargeSearchReview.MiscChargeID = msr.MiscChargeID;
                    miscChargeSearchReview.Name = msr.Name;
                    miscChargeSearchReview.Description = msr.Description;
                    miscChargeSearchReview.CalculationType = msr.CalculationType;
                    miscChargeSearchReview.Value = msr.Value;
                    miscChargeSearchReview.MisChargeCode = msr.MisChargeCode;
                    miscChargeSearchReview.IsOptional = msr.IsOptional;
                    miscChargeSearchReview.Unit = msr.Unit;
                    miscChargeSearchReview.TaxNotAvailable = msr.TaxNotAvailable;
                    miscChargeSearchReview.isQuantity = msr.IsQuantity;
                    miscChargeSearchReview.IsSelected = msr.isSelected;
                    miscChargeSearchReview.StartDate = (DateTime)reservationView.StartDate;
                    miscChargeSearchReview.EndDate = (DateTime)reservationView.EndDate;
                    miscChargeSearchReview.StartDateString = reservationView.StartDateStr;
                    miscChargeSearchReview.EndDateString = reservationView.EndDateStr;
                    if (miscChargeSearchReview.IsSelected)
                    {
                        miscChargeSearchReviews.Add(miscChargeSearchReview);
                    }

                }
                reservationView.MiscList2 = miscChargeSearchReviews;
            }
            if (taxResults.Count() > 0)
            {
                List<LocationTaxModel> locationTaxModels = new List<LocationTaxModel>();
                List<LocationTaxModel> itemsourceTax = taxList.ItemsSource as List<LocationTaxModel>;
                foreach (LocationTaxModel ltm in itemsourceTax)
                {
                    LocationTaxModel locationTaxModel = new LocationTaxModel();
                    locationTaxModel.LocationId = ltm.LocationId;
                    locationTaxModel.TaxId = ltm.TaxId;
                    locationTaxModel.Name = ltm.Name;
                    locationTaxModel.Description = ltm.Description;
                    locationTaxModel.Value = ltm.Value;
                    locationTaxModel.LocationName = ltm.LocationName;
                    locationTaxModel.IsSelected = ltm.IsSelected;
                    if (locationTaxModel.IsSelected)
                    {
                        locationTaxModels.Add(locationTaxModel);
                    }

                }
                reservationView.TaxList2 = locationTaxModels;
            }
            Navigation.PushAsync(new EditSummaryOfCharges(reservationView, reservationData));
        }

        private void CheckBox_CheckChanged(object sender, EventArgs e)
        {
            var item = (sender as Plugin.InputKit.Shared.Controls.CheckBox).BindingContext as MisChargeResult;
            misChargeResults = (IEnumerable<MischargeResultMobile>)RateList.ItemsSource;
        }

        private async void PromoBtn_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(promoCodeEntry.Text))
            {
                promotionMobileRequest.PromotionCode = promoCodeEntry.Text;
                promotionMobileRequest.LocationId = (int)reservationView.StartLocationId;
                promotionMobileRequest.VehicleTypeId = (int)reservationView.VehicleTypeID;

                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        await PopupNavigation.Instance.PushAsync(new LoadingPopup("Checking for promotion..."));

                        await Task.Run(() =>
                        {
                            try
                            {
                                promotionMobileResponse = reservationController.checkPromotion(promotionMobileRequest, token);
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
                    if (promotionMobileResponse.promotion == null)
                    {
                        await PopupNavigation.Instance.PushAsync(new Error_popup("Invalid promo code"));
                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new SuccessPopUp("Promo code successfully added."));
                        reservationView.PromotionCode = promoCodeEntry.Text;
                    }
                }
            }
        }

        private void TaxCheckbox_CheckChanged(object sender, EventArgs e)
        {

        }
    }
}