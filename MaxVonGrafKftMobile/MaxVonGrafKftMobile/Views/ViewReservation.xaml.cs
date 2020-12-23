using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using MaxVonGrafKftMobileModel.Constants;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class ViewReservation : ContentPage
    {
        private int reservationId;
        GetReservationByIDMobileRequest reservationByIDMobileRequest;
        CancelReservationMobileRequest cancelReservationMobileRequest;
        GetReservationByIDMobileResponse reservationByIDMobileResponse;
        CancelReservationMobileResponse cancelReservationMobileResponse;
        int customerId;
        string token;
        CustomerReservationModel reservationModel;

        public ViewReservation(int reservationId)
        {
            InitializeComponent();
            this.reservationId = reservationId;
            reservationByIDMobileRequest = new GetReservationByIDMobileRequest();
            reservationByIDMobileRequest.ReservationID = reservationId;
            customerId = (int)App.Current.Properties["CustomerId"];
            token = App.Current.Properties["currentToken"].ToString();
            cancelReservationMobileRequest = new CancelReservationMobileRequest();


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() == typeof(SummaryOfChargesPage)) {
            //    int c = Navigation.NavigationStack.Count;
            //    for (var counter = 1; counter < c - 2; counter++)
            //    {
            //        Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);

            //    }
            if (Navigation.NavigationStack.Count > 2)
            {
                if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() == typeof(SummaryOfChargesPage))
                {
                    int c = Navigation.NavigationStack.Count;
                    for (var counter = 1; counter < c - 2; counter++)
                    {
                        Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);

                    }


                }
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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Getting reservation details..."));

                    await Task.Run(() =>
                    {

                        try
                        {
                            reservationByIDMobileResponse = getReservationByID(reservationByIDMobileRequest, token);
                            //reservationModel = getReservation(reservationId,token);
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
                        if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup) || PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ReservationSavedPopup))
                        {
                            await PopupNavigation.Instance.PopAllAsync();
                        }
                    }

                }

            }
            if (reservationByIDMobileResponse != null)
            {
                if (reservationByIDMobileResponse.reservationData != null)
                {
                    ReservationId.Text = reservationByIDMobileResponse.reservationData.Reservationview.ReservationNumber.ToString();
                    string statusString = Enum.GetName(typeof(ReservationStatuses), reservationByIDMobileResponse.reservationData.Reservationview.Status);
                    status.Text = statusString;
                    CheckOutLocation.Text = reservationByIDMobileResponse.reservationData.Reservationview.StartLocationName;
                    CheckOutDate.Text = reservationByIDMobileResponse.reservationData.Reservationview.StartDateStr;
                    CheckInLocation.Text = reservationByIDMobileResponse.reservationData.Reservationview.EndLocationName;
                    CheckInDate.Text = reservationByIDMobileResponse.reservationData.Reservationview.EndDateStr;
                    VehicleType.Text = reservationByIDMobileResponse.reservationData.Reservationview.VehicleType;
                    NoOfDays.Text = reservationByIDMobileResponse.reservationData.Reservationview.TotalDays.ToString();
                    CreateDate.Text = String.Format("{0:MM/dd/yyyy hh:mm tt}", reservationByIDMobileResponse.reservationData.Reservationview.createdDate);
                    //CreateDate.Text = reservationByIDMobileResponse.reservationData.Reservationview.createdDate.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture);
                    Discount.Text = reservationByIDMobileResponse.reservationData.Reservationview.TotalDiscount.ToString("0.00");
                    TotalRentalFee.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.FinalBaseCharge).ToString("0.00");
                    TotalMisCharge.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.TotalMiscCharge).ToString("0.00");
                    NonMisCharge.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.TotalMischargeWithOutTax).ToString("0.00");
                    TotalTaxCharge.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.TotalTax).ToString("0.00");
                    GrandTotal.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.TotalAmount).ToString("0.00");
                    AdvancePaid.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.AmountPaid).ToString("0.00");
                    BalanceDue.Text = ((decimal)reservationByIDMobileResponse.reservationData.ReservationTotal.BalanceDue).ToString("0.00");




                    if (reservationByIDMobileResponse.reservationData.Reservationview.CustomerDriverList != null)
                    {
                        if (reservationByIDMobileResponse.reservationData.Reservationview.CustomerDriverList.Count > 0)
                        {
                            List<Driver> onlyAdditionalDriverList = new List<Driver>();
                            foreach (Driver dr in reservationByIDMobileResponse.reservationData.Reservationview.CustomerDriverList)
                            {
                                if (dr.DriverType == MaxVonGrafKftMobileModel.Constants.DriverTypes.Additional)
                                {

                                    onlyAdditionalDriverList.Add(dr);

                                }
                            }

                            if (onlyAdditionalDriverList != null)
                            {
                                if (onlyAdditionalDriverList.Count > 0)
                                {
                                    addDrivLabel.IsVisible = true;
                                    additionalDriverList.IsVisible = true;
                                    additionalDriverList.ItemsSource = onlyAdditionalDriverList;
                                    additionalDriverList.HeightRequest = (onlyAdditionalDriverList.Count) * 130;
                                }
                                else
                                {
                                    addDrivLabel.IsVisible = false;
                                    additionalDriverList.IsVisible = false;
                                }
                            }
                            else
                            {
                                addDrivLabel.IsVisible = false;
                                additionalDriverList.IsVisible = false;
                            }

                        }
                        else
                        {
                            addDrivLabel.IsVisible = false;
                            additionalDriverList.IsVisible = false;
                        }
                    }
                    else
                    {
                        addDrivLabel.IsVisible = false;
                        additionalDriverList.IsVisible = false;
                    }


                    cancelReservationMobileRequest.reservationNo = reservationByIDMobileResponse.reservationData.Reservationview.ReservationNumber.ToString();

                    string nodeValue = reservationByIDMobileResponse.reservationData.Reservationview.StartDateStr;
                    DateTimeOffset dtOffset;
                    if (reservationByIDMobileResponse.reservationData.Reservationview.Status == 2)
                    {
                        cancelBtn.IsVisible = true;
                    }
                    if (reservationByIDMobileResponse.reservationData.Reservationview.Status != 2)
                    {
                        editBtn.IsVisible = false;
                    }
                    else if (DateTimeOffset.TryParse(nodeValue, null, DateTimeStyles.None, out dtOffset))
                    {
                        DateTime checkOutDatetime = dtOffset.DateTime;
                        DateTime timeAfter1dayFromNow = DateTime.Now.AddHours(24);
                        int result = DateTime.Compare(checkOutDatetime, timeAfter1dayFromNow);
                        if (result < 0)
                        {
                            editBtn.IsVisible = false;
                        }
                        else
                        {
                            editBtn.IsVisible = true;
                        }
                    }
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new Error_popup(reservationByIDMobileResponse.message.ErrorMessage));
                }
            }
        }

        private GetReservationByIDMobileResponse getReservationByID(GetReservationByIDMobileRequest reservationByIDMobileRequest, string token)
        {
            GetReservationByIDMobileResponse getReservationByID = null;
            RegisterController register = new RegisterController();
            try
            {
                getReservationByID = register.getReservationByID(reservationByIDMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return getReservationByID;
        }

        //private CustomerReservationModel getReservation(int reservationId, string token)
        //{
        //    CustomerReservationModel model = null;
        //    RegisterController register = new RegisterController();
        //    try
        //    {
        //        model = register.getReservation(reservationId, token);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return model;
        //}

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            if (reservationByIDMobileResponse.reservationData.Reservationview.Status == 2)
            {
                cancelReservationMobileRequest.reservationNo = reservationByIDMobileResponse.reservationData.Reservationview.ReservationNumber.ToString();
                cancelReservationMobileRequest.CurrentTime = DateTime.Now;
                cancelReservationMobileRequest.isTwoHour = true;
                cancelReservation(cancelReservationMobileRequest, token);
            }
        }

        private async void cancelReservation(CancelReservationMobileRequest cancelReservationMobileRequest, string token)
        {
            ReservationController reservationController = new ReservationController();
            CancelReservationMobileResponse response = null;

            bool cancelConfirm = await DisplayAlert("Alert", "Are you sure want to cancel reservation", "Confirm", "Back");
            if (cancelConfirm)
            {

                bool busy = false;
                if (!busy)
                {
                    try
                    {
                        busy = true;
                        await PopupNavigation.Instance.PushAsync(new LoadingPopup("Cancelling Reservation"));
                        await Task.Run(() =>
                        {

                            response = reservationController.cancelReservation(cancelReservationMobileRequest, token);
                        });
                    }
                    finally
                    {
                        busy = false;
                        await PopupNavigation.Instance.PopAllAsync();

                        if (Convert.ToInt32(response.ReservationNumber) > 0)
                        {
                            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() == typeof(SummaryOfChargesPage))
                            {
                                //int c = Navigation.NavigationStack.Count;
                                //for (var counter = 1; counter < c - 2; counter++)
                                //{
                                //    Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);

                                //}
                                await Navigation.PushAsync(new HomePageDetail());
                            }

                            //if (Navigation.NavigationStack [Navigation.NavigationStack.Count - 1].GetType() == typeof(SummaryOfChargesPage))
                            //{
                            //    await Navigation.PushAsync(new HomePageDetail());
                            //}
                            else
                            {
                                await Navigation.PushAsync(new HomePageDetail());
                            }
                        }

                    }
                }
            }


        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(HomePage))
            {
                Navigation.PushAsync(new HomePage());
            }
        }
        //protected override bool OnBackButtonPressed()
        //{
        //    if (Navigation.NavigationStack.Count >= 2)
        //    {
        //        if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 2].GetType() == typeof(SummaryOfChargesPage))
        //        {
        //            Navigation.PushAsync(new HomePage());
        //        }

        //    }
        //    return false;
        //}

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void editBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new EditBookNow(reservationByIDMobileResponse.reservationData));
        }

        private void additionalDriverList_Refreshing(object sender, EventArgs e)
        {

        }
    }
}