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
    public partial class SavedSuccessfullyPopup : PopupPage
    {
        public SavedSuccessfullyPopup()
        {
            InitializeComponent();
        }

        private async void Okbtn_Clicked(object sender, EventArgs e)
        {

            for (var counter = 1; counter < 3; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
            }
            await Navigation.PopAsync();
            await PopupNavigation.Instance.PopAllAsync();
        }
    }
}