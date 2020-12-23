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
    public partial class QuitApplication : PopupPage
    {
        public QuitApplication()
        {
            InitializeComponent();
        }

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        private async void YesBtn_Clicked(object sender, EventArgs e)
        {

            int c = Navigation.NavigationStack.Count+2;
            for (var counter = 1; counter < c; counter++)
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
            }
            await PopupNavigation.Instance.PopAllAsync();

        }
    }
}