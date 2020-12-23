using MaxVonGrafKftMobile.Views;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationSavedPopup : PopupPage
    {
        private int reservationNumber;

        

        public ReservationSavedPopup(int v)
        {
            InitializeComponent();
            this.reservationNumber = v;
        }

        private async void DashboardBtn_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new HomePage());
        }

        private async void ReservationBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ViewReservation(reservationNumber));
        }
    }
}