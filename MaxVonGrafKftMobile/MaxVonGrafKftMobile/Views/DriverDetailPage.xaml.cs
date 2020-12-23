using MaxVonGrafKftMobileModel;
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
    public partial class DriverDetailPage : ContentPage
    {
        private Driver selecteddriver;
        private ReservationView reservationView;


        public DriverDetailPage(Driver selecteddriver, ReservationView reservationView)
        {
            InitializeComponent();
            this.selecteddriver = selecteddriver;
            this.reservationView = reservationView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            FnameEntry.Text = selecteddriver.FirstName;
            LnameEntry.Text = selecteddriver.LastName;
            phoneEntry.Text = selecteddriver.hPhone;
            emailEntry.Text = selecteddriver.Email;
            cityEntry.Text = selecteddriver.City;
            addresssEntry.Text = selecteddriver.Address1;
            dateOfBirthEntry.Text = selecteddriver.DateofBirth.ToString();
            licNoEntry.Text = selecteddriver.DriverLicenseNumber;
        }

        private void dltBtn_Clicked(object sender, EventArgs e)
        {
            int cusId = selecteddriver.CustomerId;
            int dId = selecteddriver.DriverId;
            foreach (Driver d in reservationView.CustomerDriverList)
            {
                if (d.CustomerId > 0)
                {
                    if (d.CustomerId == cusId)
                    {
                        d.IsDelete = true;
                    }
                }
                else if (d.DriverId > 0)
                {
                    if (d.DriverId == dId)
                    {
                        d.IsDelete = true;
                    }
                }

            }
            Navigation.PopAsync();
        }
    }
}