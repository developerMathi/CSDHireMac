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
    public partial class SuccessWithClosePopup : PopupPage
    {
        public SuccessWithClosePopup(string content)
        {
            InitializeComponent();
            contentText.Text = content;
        }


        private void Okbtn_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}