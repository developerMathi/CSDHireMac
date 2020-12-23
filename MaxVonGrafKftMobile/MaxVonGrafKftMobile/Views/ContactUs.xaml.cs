using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class ContactUs : ContentPage
    {
        EmailContactusRes emailContactusRes;
        EmailContactusReq emailContactusReq;
        string token;

        public ContactUs()
        {
            InitializeComponent();
            emailContactusReq = new EmailContactusReq();
            emailContactusRes = null;
            token = Application.Current.Properties["currentToken"].ToString();
            subjectEntry.Text = "CSD Mobile ContactUs details";

        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (PopupNavigation.Instance.PopupStack.Count > 0)
            {
                if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() == typeof(ErrorWithClosePagePopup))
                {
                    await PopupNavigation.Instance.PopAllAsync();
                }
            }

        }

        private async void SubmitBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a name."));
            }
            else if (!new EmailAddressAttribute().IsValid(emailEntry.Text) || string.IsNullOrEmpty(emailEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid email address"));
            }
            else if (string.IsNullOrEmpty(phoneEntry.Text)|| phoneEntry.Text.Length<10|| phoneEntry.Text.Length > 20)
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a valid contactNo."));
            }
            else if (string.IsNullOrEmpty(subjectEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter a subject"));
            }
            else if (string.IsNullOrEmpty(messageEntry.Text))
            {
                await PopupNavigation.Instance.PushAsync(new Error_popup("Please enter your message"));
            }
            else
            {
                emailContactusReq.email = emailEntry.Text;
                emailContactusReq.name = nameEntry.Text;
                emailContactusReq.phonenumber = phoneEntry.Text;
                emailContactusReq.subject = subjectEntry.Text;
                emailContactusReq.message = messageEntry.Text;
                emailContactusReq.templatekey = "EmailTemplateCSD";

                CommonController controller = new CommonController();
                try
                {
                    emailContactusRes = controller.contactUs(emailContactusReq, token);
                }
                catch(Exception ex)
                {
                    await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(ex.Message));
                }
                if (emailContactusRes!= null)
                {
                    if (emailContactusRes.message.ErrorCode == "200")
                    {
                        await PopupNavigation.Instance.PushAsync(new SuccessWithClosePopup("Your information saved successfully"));
                    }
                }
            }
        }
    }
}