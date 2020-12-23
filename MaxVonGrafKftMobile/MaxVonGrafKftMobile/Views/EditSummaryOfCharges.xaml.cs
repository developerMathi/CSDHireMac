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
    public partial class EditSummaryOfCharges : ContentPage
    {
        private ReservationView reservationView;
        GetCalculateSummaryMobileRequest summaryMobileRequest;
        UpdateReservationMobileRequest ReservationMobileRequest;
        UpdateReservationMobileResponse ReservationMobileResponse;
        GetCalculateSummaryMobileResponsecs summaryMobileResponsecs;
        GetTermsandConditionByTypeRequest termsandConditionByTypeRequest;
        GetTermsandConditionByTypeResponse termsandConditionByTypeResponse;
        ReservationViewModel reservationData;
        private string token;
        public EditSummaryOfCharges(ReservationView reservationView, ReservationViewModel reservationData)
        {
            InitializeComponent();
            var assembly = typeof(SummaryOfChargesPage);
            this.reservationView = reservationView;
            summaryMobileRequest = new GetCalculateSummaryMobileRequest();
            summaryMobileResponsecs = null;
            ReservationMobileResponse = null;
            ReservationMobileRequest = new UpdateReservationMobileRequest();
            summaryMobileRequest.reservation = reservationView;
            token = App.Current.Properties["currentToken"].ToString();
            termsandConditionByTypeRequest = new GetTermsandConditionByTypeRequest();
            termsandConditionByTypeRequest.clientId = Constants.ClientId;
            termsandConditionByTypeRequest.typeId = 3;
            termsandConditionByTypeResponse = null;
            this.reservationData = reservationData;
        }

        //private async void LoginIcon_Clicked(object sender, EventArgs e)
        //{
        //    var assembly = typeof(SummaryOfChargesPage);
        //    if ((int)App.Current.Properties["CustomerId"] == 0)
        //    {

        //        loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.logOutTool.png", assembly);
        //        await Navigation.PushAsync(new LoginPage());

        //    }
        //    else
        //    {
        //        bool logout = await DisplayAlert("Alert", "Are you sure want to logout", "Yes", "No");
        //        if (logout)
        //        {
        //            App.Current.Properties["CustomerId"] = 0;
        //            loginIcon.IconImageSource = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.LogInTool.png", assembly);
        //            await Navigation.PushAsync(new BookNow());
        //        }
        //    }
        //}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
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
            if (reservationData.Reservationview.CustomerDriverList != null)
            {
                reservationView.CustomerDriverList = reservationData.Reservationview.CustomerDriverList;
                if (reservationView.CustomerDriverList.Count > 0)
                {
                    List<Driver> listForListVew = new List<Driver>();
                    foreach (Driver d in reservationView.CustomerDriverList)
                    {
                        if (d.IsDelete == false)
                        {
                            listForListVew.Add(d);
                        }
                    }
                    reservationView.CustomerDriverList = reservationView.CustomerDriverList;
                    NoAdditionalDriverLabel.IsVisible = false;
                    additionalDriverList.IsVisible = true;
                    additionalDriverList.ItemsSource = listForListVew;
                    additionalDriverList.HeightRequest = (listForListVew.Count) * 130;
                }
                else
                {
                    NoAdditionalDriverLabel.IsVisible = true;
                    additionalDriverList.IsVisible = false;
                }
            }
            else
            {
                NoAdditionalDriverLabel.IsVisible = true;
                additionalDriverList.IsVisible = false;
            }

            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Getting summary details..."));

                    await Task.Run(() =>
                    {
                        try
                        {
                            summaryMobileResponsecs = getSummaryDetails(summaryMobileRequest, token);
                            termsandConditionByTypeResponse = getTermsAndConditions(termsandConditionByTypeRequest, token);
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

                    if (summaryMobileResponsecs != null)
                    {
                        if (summaryMobileResponsecs.message.ErrorCode == "200")
                        {
                            VehicletypeEntry.Text = reservationView.VehicleType;
                            noOfDaysEntry.Text = reservationView.TotalDays.ToString();

                            if (summaryMobileResponsecs.rate.ReservationSummary.BaseRate == null)
                            {
                                totalRentalFeeEntry.Text = summaryMobileResponsecs.rate.EstimatedTotal.ToString();
                            }
                            else if (summaryMobileResponsecs.rate.ReservationSummary.BaseRate != null)
                            {
                                totalRentalFeeEntry.Text = summaryMobileResponsecs.rate.ReservationSummary.BaseRate;
                            }

                            totalMisChargeEntry.Text = (Convert.ToDecimal(summaryMobileResponsecs.rate.ReservationSummary.TotacMiscTaxable)).ToString("0.00");
                            nonMisChargeEntry.Text = (Convert.ToDecimal(summaryMobileResponsecs.rate.ReservationSummary.TotacMiscNonTaxable)).ToString("0.00");

                            if (summaryMobileResponsecs.rate.ReservationSummary.TotalTax == null)
                            {
                                totalTaxEntry.Text = "0.00";
                            }
                            else if (summaryMobileResponsecs.rate.ReservationSummary.TotalTax != null)
                            {
                                totalTaxEntry.Text = summaryMobileResponsecs.rate.ReservationSummary.TotalTax;
                            }

                            if (summaryMobileResponsecs.rate.ReservationSummary.EstimatedTotal == null)
                            {
                                totalAmountEntry.Text = summaryMobileResponsecs.rate.EstimatedTotal.ToString();
                            }
                            else if (summaryMobileResponsecs.rate.ReservationSummary.EstimatedTotal != null)
                            {
                                totalAmountEntry.Text = summaryMobileResponsecs.rate.ReservationSummary.EstimatedTotal;
                            }

                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(summaryMobileResponsecs.message.ErrorMessage));
                        }
                    }

                    if (termsandConditionByTypeResponse != null)
                    {
                        if (termsandConditionByTypeResponse.message.ErrorCode == "200")
                        {
                            if (termsandConditionByTypeResponse.termlist != null)
                            {
                                if (termsandConditionByTypeResponse.termlist.Count > 0)
                                {
                                    //terms.Text = termsandConditionByTypeResponse.termlist[0].Term;
                                    //tacDescription.Text = termsandConditionByTypeResponse.termlist[0].Description;

                                    termList.ItemsSource = termsandConditionByTypeResponse.termlist;
                                }
                            }
                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(termsandConditionByTypeResponse.message.ErrorMessage));
                        }
                    }
                }
            }
        }

        private GetTermsandConditionByTypeResponse getTermsAndConditions(GetTermsandConditionByTypeRequest termsandConditionByTypeRequest, string token)
        {
            GetTermsandConditionByTypeResponse Response = null;
            ReservationController controller = new ReservationController();
            try
            {
                Response = controller.getTermsAndConditions(termsandConditionByTypeRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Response;
        }

        private GetCalculateSummaryMobileResponsecs getSummaryDetails(GetCalculateSummaryMobileRequest summaryMobileRequest, string token)
        {
            GetCalculateSummaryMobileResponsecs summaryResponse = null;
            ReservationController controller = new ReservationController();
            try
            {
                summaryResponse = controller.getSummaryDetails(summaryMobileRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return summaryResponse;
        }

        private async void BookNowBtn_Clicked(object sender, EventArgs e)
        {
            if (TCcheckBox.IsChecked)
            {
                if ((int)App.Current.Properties["CustomerId"] == 0)
                {
                    await PopupNavigation.Instance.PushAsync(new AskForLogin("Please login for continue your booking"));
                }
                else
                {
                    reservationView.CustomerId = (int)App.Current.Properties["CustomerId"];
                    reservationView.BasePrice = Convert.ToDecimal(summaryMobileResponsecs.rate.ReservationSummary.BaseRate);
                    reservationView.ReservationNumber = reservationData.Reservationview.ReservationNumber;
                    reservationView.EstimatedTotal = Convert.ToDecimal(summaryMobileResponsecs.rate.ReservationSummary.EstimatedTotal);
                    reservationView.Status = reservationData.Reservationview.Status;
                    reservationView.ReservationStatus = reservationData.Reservationview.ReservationStatus;
                    reservationView.StatusId = reservationData.Reservationview.StatusId;
                    ReservationMobileRequest.reservationData = reservationView;
                    bool busy = false;
                    if (!busy)
                    {
                        try
                        {
                            busy = true;
                            await PopupNavigation.Instance.PushAsync(new LoadingPopup("Upadating reservation..."));

                            await Task.Run(() =>
                            {
                                try
                                {
                                    ReservationMobileResponse = updateReservationMobile(ReservationMobileRequest, token);
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

                            if (ReservationMobileResponse != null)
                            {
                                if (ReservationMobileResponse.message.ErrorCode == "200")
                                {
                                    if (ReservationMobileResponse.ReservID > 0)
                                    {
                                        await PopupNavigation.Instance.PushAsync(new ReservationSavedPopup(ReservationMobileResponse.ReservID));
                                    }
                                    else
                                    {
                                        await PopupNavigation.Instance.PushAsync(new Error_popup("Something went wrong"));
                                    }
                                }
                                else
                                {
                                    await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(ReservationMobileResponse.message.ErrorMessage));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please accept the terms and conditions"));
            }
        }

        private UpdateReservationMobileResponse updateReservationMobile(UpdateReservationMobileRequest reservationMobileRequest, string token)
        {
            UpdateReservationMobileResponse response = null;
            ReservationController reservationController = new ReservationController();
            try
            {
                response = reservationController.updateReservationMobile(reservationMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        protected override bool OnBackButtonPressed()
        {
            if (PopupNavigation.Instance.PopupStack.Count > 0) { return true; }



            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            return false;
        }

        /// <summary>
        /// additoinal driver btn click method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addDriverBtn_Clicked(object sender, EventArgs e)
        {
            if ((int)App.Current.Properties["CustomerId"] == 0)
            {
                PopupNavigation.Instance.PushAsync(new AskForLogin("Please log in to your account."));
            }
            else
            {
                Navigation.PushAsync(new EditAddAditionalDiver(reservationView, reservationData));
            }
        }

        private void additionalDriverList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Driver selecteddriver = additionalDriverList.SelectedItem as Driver;
            Navigation.PushAsync(new DriverDetailPage(selecteddriver, reservationView));
        }

        private void additionalDriverList_Refreshing(object sender, EventArgs e)
        {

        }
    }
}