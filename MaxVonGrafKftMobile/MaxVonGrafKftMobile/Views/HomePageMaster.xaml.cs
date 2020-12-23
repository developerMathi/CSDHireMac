using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class HomePageMaster : ContentPage
    {
        public ListView ListView;

        public HomePageMaster()
        {
            InitializeComponent();

            BindingContext = new HomePageMasterViewModel();
            ListView = MenuItemsListView;


            var homeTab = new TapGestureRecognizer();
            homeTab.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new HomePageDetail());
            };
            HomeBtn.GestureRecognizers.Add(homeTab);
        }

        class HomePageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomePageMasterMenuItem> MenuItems { get; set; }

            public HomePageMasterViewModel()
            {
                MenuItems = new ObservableCollection<HomePageMasterMenuItem>(new[]
                {

                    new HomePageMasterMenuItem { Id = 0, Title = "Dashboard" },
                    new HomePageMasterMenuItem { Id = 1, Title = "Book Now" },
                    new HomePageMasterMenuItem { Id = 2, Title = "Upcoming reservation " },
                    new HomePageMasterMenuItem { Id = 3, Title = "My Rentals" },
                    new HomePageMasterMenuItem { Id = 4, Title = "My Profile" },
                    new HomePageMasterMenuItem { Id = 5, Title = "Log out" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}