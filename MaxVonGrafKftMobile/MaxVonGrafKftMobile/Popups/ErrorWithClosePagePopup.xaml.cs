using Rg.Plugins.Popup.Pages;
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
    public partial class ErrorWithClosePagePopup : PopupPage
    {
        public ErrorWithClosePagePopup(string content)
        {
            InitializeComponent();
            contentText.Text = content;
        }

        private void Okbtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}