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
    public partial class DamageCheckListCheckOut : ContentPage
    {
        private int agreementId;
        private int VehicleId;
        private string AgreementNumber;
        GetChecklistMobileResponse checklistMobileResponse;
        private string token;
        GetChecklistMobileRequest checklistMobileRequest;
        private int status;
        AddDamageSignMobileRequest SignMobileRequest;
        AddDamageSignMobileResponse signMobileResponse;
        ReloadSignatureImageURLMobileRequest imageURLMobileRequest;
        ReloadSignatureImageURLMobileResponse imageURLMobileResponse;
        public List<VehicleDamageImageForList> vehicleDamageImageList = new List<VehicleDamageImageForList>();

        public DamageCheckListCheckOut(int agreementId, string agreementNo, int status, int VehicleId)
        {
            InitializeComponent();
            this.agreementId = agreementId;
            AgreementNumber = agreementNo;
            this.VehicleId = VehicleId;
            this.status = status;
            checklistMobileRequest = new GetChecklistMobileRequest();
            checklistMobileRequest.AgreementId = agreementId;
            checklistMobileRequest.clientId = Constants.ClientId;
            checklistMobileResponse = null;
            token = App.Current.Properties["currentToken"].ToString();
            signMobileResponse = null;
            SignMobileRequest = new AddDamageSignMobileRequest();
            imageURLMobileRequest = new ReloadSignatureImageURLMobileRequest();
            imageURLMobileRequest.agreementId = agreementId;
            imageURLMobileRequest.IsCheckIn = false;
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
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (vehicleDamageImageList == null)
            {
                List<string> titles = new List<string>();
                titles.Add("Front");
                titles.Add("Rear");
                titles.Add("Left");
                titles.Add("Right");

                for (int i = 0; i < titles.Count; i++)
                {
                    VehicleDamageImageForList damageImageForList = new VehicleDamageImageForList();
                    damageImageForList.Title = titles[i];
                    damageImageForList.agreementId = agreementId;


                }

            }


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            if (status == 3 || status == 5 || status == 7)
            {
                checklistBtn.IsVisible = true;
                signaturePadFrame.IsVisible = false;
                signaturePadGrid.IsVisible = false;
                imageFrame.IsVisible = false;
                noSignatureFrame.IsVisible = true;
            }
            if (status == 2)
            {
                checklistBtn.IsVisible = false;
                signaturePadFrame.IsVisible = true;
                signaturePadGrid.IsVisible = true;
                imageFrame.IsVisible = false;
                noSignatureFrame.IsVisible = false;
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


                        foreach (DefaultDamageList ddm in checklistMobileResponse.DefaultDamageChecklistout)
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
                            checklistBtn.IsVisible = true;
                            signaturePadFrame.IsVisible = false;
                            signaturePadGrid.IsVisible = false;
                            imageFrame.IsVisible = true;
                            noSignatureFrame.IsVisible = false;
                            checklistBtn.IsVisible = false;
                            if (status == 3 || status == 5 || status == 7)
                            {
                                checklistBtn.IsVisible = true;
                            }
                            if (status == 2)
                            {
                                checklistBtn.IsVisible = false;
                            }
                        }
                        else
                        {
                            if (status == 3 || status == 5 || status == 7)
                            {
                                checklistBtn.IsVisible = true;
                                signaturePadFrame.IsVisible = false;
                                signaturePadGrid.IsVisible = false;
                                imageFrame.IsVisible = false;
                                noSignatureFrame.IsVisible = true;


                            }
                            if (status == 2)
                            {
                                checklistBtn.IsVisible = false;
                                signaturePadFrame.IsVisible = true;
                                signaturePadGrid.IsVisible = true;
                                imageFrame.IsVisible = false;
                                noSignatureFrame.IsVisible = false;
                            }
                        }
                    }
                    else
                    {
                        if (status == 3 || status == 5 || status == 7)
                        {
                            checklistBtn.IsVisible = true;
                            signaturePadFrame.IsVisible = false;
                            signaturePadGrid.IsVisible = false;
                            imageFrame.IsVisible = false;
                            noSignatureFrame.IsVisible = true;
                        }
                        if (status == 2)
                        {
                            checklistBtn.IsVisible = false;
                            signaturePadFrame.IsVisible = true;
                            signaturePadGrid.IsVisible = true;
                            imageFrame.IsVisible = false;
                            noSignatureFrame.IsVisible = false;
                        }
                    }
                }



            }

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
                    SignMobileRequest.ischeckin = false;




                    signMobileResponse = saveDamageSignature(SignMobileRequest, token);
                    if (signMobileResponse != null)
                    {
                        if (signMobileResponse.message.ErrorCode == "200")
                        {
                            signaturePadGrid.IsVisible = false;
                            await PopupNavigation.Instance.PushAsync(new SuccessPopUp("Your signature saved successfully"));
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


        private void BackBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void checklistBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DamageCheckListCheckIn(agreementId, AgreementNumber, VehicleId));
        }

        private void VehicleImageBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VehicleDamageImage(agreementId, AgreementNumber, VehicleId, "out"));
        }

       
    }
}