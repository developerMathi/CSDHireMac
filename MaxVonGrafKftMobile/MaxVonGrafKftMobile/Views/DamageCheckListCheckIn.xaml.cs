using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using MaxVonGrafKftMobileModel.AccessModels;
using Rg.Plugins.Popup.Services;
using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class DamageCheckListCheckIn : ContentPage
    {
        private int agreementId;
        GetChecklistMobileResponse checklistMobileResponse;
        private string token;
        string agreementNumber;
        int vehicleId;
        GetChecklistMobileRequest checklistMobileRequest;
        AddDamageSignMobileRequest SignMobileRequest;
        AddDamageSignMobileResponse signMobileResponse;
        ReloadSignatureImageURLMobileRequest imageURLMobileRequest;
        ReloadSignatureImageURLMobileResponse imageURLMobileResponse;

        public DamageCheckListCheckIn(int agreementId, string AgreementNumber, int VehicleId)
        {
            InitializeComponent();
            this.agreementId = agreementId;
            this.agreementNumber = AgreementNumber;
            this.vehicleId = VehicleId;
            checklistMobileRequest = new GetChecklistMobileRequest();
            checklistMobileRequest.AgreementId = agreementId;
            checklistMobileRequest.clientId = Constants.ClientId;
            checklistMobileResponse = null;
            token = App.Current.Properties["currentToken"].ToString();
            SignMobileRequest = new AddDamageSignMobileRequest();
            signMobileResponse = null;
            imageURLMobileRequest = new ReloadSignatureImageURLMobileRequest();
            imageURLMobileRequest.agreementId = agreementId;
            imageURLMobileRequest.IsCheckIn = true;
            imageURLMobileRequest.isDamageView = true;
            imageURLMobileResponse = null;
            imageURLMobileRequest.SignatureImageUrl = "";

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

            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Loading damage list..."));

                    await Task.Run(async () =>
                    {
                        try
                        {
                            checklistMobileResponse = getDamageCheckListMobile(checklistMobileRequest, token);
                            imageURLMobileResponse = getDamageSignature(imageURLMobileRequest, token);
                        }
                        catch (Exception ex)
                        {
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
                if (checklistMobileResponse != null)
                {
                    if (checklistMobileResponse.message.ErrorCode == "200")
                    {
                        List<DefaultDamageList> optionList = new List<DefaultDamageList>();
                        List<DefaultDamageList> nonOptionList = new List<DefaultDamageList>();
                        List<DefaultDamageList> calenderList = new List<DefaultDamageList>();

                        foreach (DefaultDamageList ddm in checklistMobileResponse.DefaultDamageChecklistIn)
                        {
                            if (ddm.SelectOption == "Optional")
                            {
                                optionList.Add(ddm);
                            }
                            else if (ddm.SelectOption == "ShortAnswer")
                            {
                                nonOptionList.Add(ddm);
                            }
                            else if (ddm.SelectOption == "Calendar")
                            {
                                calenderList.Add(ddm);
                            }
                        }


                        damageList.ItemsSource = optionList;
                        damageList.HeightRequest = 84 * optionList.Count;

                        damageListNonOption.ItemsSource = nonOptionList;
                        damageListNonOption.HeightRequest = 42 * nonOptionList.Count;

                        damageListCalender.ItemsSource = calenderList;
                        damageListCalender.HeightRequest = 42 * calenderList.Count;

                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(checklistMobileResponse.message.ErrorMessage));
                    }
                }
                if (imageURLMobileResponse != null)
                {
                    if (imageURLMobileResponse.message.ErrorCode == "200")
                    {
                        if (!string.IsNullOrEmpty(imageURLMobileResponse.SignatureImageUrl))
                        {
                            byte[] Base64Stream = Convert.FromBase64String(imageURLMobileResponse.SignatureImageUrl);
                            signatureImage.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
                            signaturePadFrame.IsVisible = false;
                            signatureBtnGrid.IsVisible = false;
                            imageFrame.IsVisible = true;
                        }
                        else
                        {
                            signatureBtnGrid.IsVisible = true;
                            signatureView.IsVisible = true;
                            imageFrame.IsVisible = false;
                        }
                    }
                    else
                    {
                        signatureBtnGrid.IsVisible = true;
                        signatureView.IsVisible = true;
                        imageFrame.IsVisible = false;
                    }
                }
                else
                {
                    signatureBtnGrid.IsVisible = true;
                    signatureView.IsVisible = true;
                    imageFrame.IsVisible = false;
                }
            }
        }

        private ReloadSignatureImageURLMobileResponse getDamageSignature(ReloadSignatureImageURLMobileRequest imageURLMobileRequest, string token)
        {
            ReloadSignatureImageURLMobileResponse response = null;
            AgreementController controller = new AgreementController();
            try
            {
                response = controller.getDamageSignature(imageURLMobileRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        private GetChecklistMobileResponse getDamageCheckListMobile(GetChecklistMobileRequest checklistMobileRequest, string token)
        {
            GetChecklistMobileResponse response = null;
            VehicleController vehicle = new VehicleController();
            try
            {
                response = vehicle.getDamageCheckListMobile(checklistMobileRequest, token);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        private void ClearSigBtn_Clicked(object sender, EventArgs e)
        {
            signatureView.Clear();
        }

        private async void SaveSignatureBtn_Clicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Alert", "Are you sure want to save ?", "Yes", "No");
            if (confirm)
            {

                SignMobileRequest.agreementId = agreementId;
                //Stream bitmap = await signatureView.GetImageStreamAsync(SignatureImageFormat.Png);



                //StreamReader reader = new StreamReader(bitmap);

                //byte[] bytedata = System.Text.Encoding.Default.GetBytes(reader.ReadToEnd());

                Stream img = await signatureView.GetImageStreamAsync(SignatureImageFormat.Png);

                if (img != null)
                {
                    signatureView.IsEnabled = false;
                    BinaryReader br = new BinaryReader(img);
                    br.BaseStream.Position = 0;
                    Byte[] All = br.ReadBytes((int)img.Length);

                    string strBase64 = Convert.ToBase64String(All);
                    SignMobileRequest.base64Img = strBase64;
                    SignMobileRequest.ischeckin = true;




                    signMobileResponse = saveDamageSignature(SignMobileRequest, token);
                    if (signMobileResponse != null)
                    {
                        if (signMobileResponse.message.ErrorCode == "200")
                        {
                            await PopupNavigation.Instance.PushAsync(new SuccessPopUp("Your signature saved successfully"));
                            signatureView.IsEnabled = false;
                            signatureBtnGrid.IsVisible = false;
                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup(signMobileResponse.message.ErrorMessage));
                        }
                    }
                }
                else
                {
                    await PopupNavigation.Instance.PushAsync(new Error_popup("Invalid signature"));
                }
            }
        }

        private AddDamageSignMobileResponse saveDamageSignature(AddDamageSignMobileRequest signMobileRequest, string token)
        {
            AgreementController agreementController = new AgreementController();
            AddDamageSignMobileResponse response = null;
            try
            {
                response = agreementController.saveDamageSignature(signMobileRequest, token);
            }
            catch (Exception e)
            {
                throw e;
            }
            return response;
        }

        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void VehicleImageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VehicleDamageImage(agreementId, agreementNumber, vehicleId,"in"));
        }

       
    }
}