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
    public partial class BookingLose : PopupPage
    {
        public BookingLose()
        {
            InitializeComponent();
        }

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        private void YesBtn_Clicked(object sender, EventArgs e)
        {
            int c = Navigation.NavigationStack.Count;
            for (var counter = 1; counter < c - 1; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            }
            Navigation.PopAsync();
            PopupNavigation.Instance.PopAllAsync();
        }
    }
}