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

    public partial class HomePageDetail : ContentPage
    {
        RegistrationDBModel registrationDBModel;
        GetReservationAgreementMobileRequest registrationDBModelRequest;
        GetReservationAgreementMobileResponse registrationDBModelResponse;
        int customerId;

        string _token;
        public HomePageDetail()
        {
            InitializeComponent();
            customerId = (int)Application.Current.Properties["CustomerId"];
            _token = Application.Current.Properties["currentToken"].ToString();
            registrationDBModelRequest = new GetReservationAgreementMobileRequest();
            registrationDBModelRequest.customerId = customerId;
            registrationDBModelResponse = null;
            registrationDBModel = null;

        }

        protected override async void OnAppearing()
        {
            
            base.OnAppearing();
            Constants.IsHome = true;
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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Loading.."));

                    await Task.Run(async () =>
                    {
                        try
                        {
                            //registrationDBModel = getRegistrationDBModel(customerId, _token);
                            registrationDBModelResponse = getMobileRegistrationDBModel(registrationDBModelRequest, _token);
                        }

                        //registrationDBModel.Reservations[0].ReservationId
                        catch (Exception ex)
                        {
                            App.Current.Properties["CustomerId"] = 0;
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

                if (registrationDBModelResponse != null)
                {
                    if (registrationDBModelResponse.message.ErrorCode == "200")
                    {
                        registrationDBModel = registrationDBModelResponse.regDB;
                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(registrationDBModelResponse.message.ErrorMessage));
                    }
                }
            }
            if (registrationDBModel != null)
            {
                if (registrationDBModel.Reservations.Count > 0)
                {
                    List<CustomerReservationModel> upreserItemSource = new List<CustomerReservationModel>();
                  
                    upcomingReservation.ItemsSource = registrationDBModel.Reservations;
                    upcomingReservation.HeightRequest = registrationDBModel.Reservations.Count * 220;
                }
                else
                {
                    upcomingReservation.IsVisible = false;
                    emptyReservation.IsVisible = true;
                    upReserveFrame.HeightRequest = 290;
                }


                if (registrationDBModel.Agreements.Count > 0)
                {

                    List<CustomerAgreementModel> agreementItemSource = new List<CustomerAgreementModel>();
                   

                    myRentals.ItemsSource = registrationDBModel.Agreements;
                    myRentals.HeightRequest = registrationDBModel.Agreements.Count * 220;
                }
                else
                {
                    myRentals.IsVisible = false;
                    emptyMyrentals.IsVisible = true;
                    myRentFrame.HeightRequest = 290;
                }


                var AllReservationTap = new TapGestureRecognizer();
                AllReservationTap.Tapped += async (s, e) =>
                {
                    Constants.IsHome = false;
                    if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(UpcomingReservations))
                    {
                        await Navigation.PushAsync(new UpcomingReservations());
                    }
                };
                allReservationLabel.GestureRecognizers.Add(AllReservationTap);

                var AllmyrentalsTap = new TapGestureRecognizer();
                AllmyrentalsTap.Tapped += async (s, e) =>
                {
                    Constants.IsHome = false;
                    if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(MyRentals))
                    {
                        await Navigation.PushAsync(new MyRentals());
                    }
                };
                allAgreementLabel.GestureRecognizers.Add(AllmyrentalsTap);
            }



        }

        private GetReservationAgreementMobileResponse getMobileRegistrationDBModel(GetReservationAgreementMobileRequest registrationDBModelRequest, string token)
        {
            GetReservationAgreementMobileResponse response = null;
            try
            {
                RegisterController registerController = new RegisterController();
                response = registerController.getMobileRegistrationDBModel(registrationDBModelRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        //private RegistrationDBModel getRegistrationDBModel(int customerId, string _token)
        //{
        //    RegisterController register = new RegisterController();
        //    return register.getRegistrationDBModel(customerId, _token);
        //}

        private void BooknowBtn_Clicked(object sender, EventArgs e)
        {
            Constants.IsHome = false;
            Navigation.PushAsync(new BookNow());
        }

        private void UpcomingReservation_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CustomerReservationModel reservationModel = upcomingReservation.SelectedItem as CustomerReservationModel;
            ((ListView)sender).SelectedItem = null;
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(ViewReservation))
            {
                Constants.IsHome = false;
                Navigation.PushAsync(new ViewReservation(reservationModel.ReservationId));
            }
        }

        private void MyRentals_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            CustomerAgreementModel agreementModel = myRentals.SelectedItem as CustomerAgreementModel;
            ((ListView)sender).SelectedItem = null;
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(ViewMyRental))
            {
                Constants.IsHome = false;
                Navigation.PushAsync(new ViewMyRental(agreementModel.AgreementId));
            }
        }
    }
}