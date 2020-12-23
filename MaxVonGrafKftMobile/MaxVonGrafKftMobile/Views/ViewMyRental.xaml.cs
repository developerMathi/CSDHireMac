using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel.AccessModels;
using MaxVonGrafKftMobileModel.Constants;
using PdfSharp.Xamarin.Forms;
using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using Rg.Plugins.Popup.Services;
using SignaturePad.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Views
{
    public partial class ViewMyRental : ContentPage
    {
        private int agreementId;
        private string token;
        GetAgreementByAgreementIdMobileRequest AgreementByAgreementIdMobileRequest;
        GetAgreementByAgreementIdMobileResponse AgreementByAgreementIdMobileResponse;
        AddAgreementSignMobileRequest signMobileRequest;
        AddAgreementSignMobileResponse signMobileResponse;
        ReloadSignatureImageURLMobileRequest imageURLMobileRequest;
        ReloadSignatureImageURLMobileResponse imageURLMobileResponse;



        public ViewMyRental(int agreementId)
        {
            InitializeComponent();
            this.agreementId = agreementId;
            token = App.Current.Properties["currentToken"].ToString();
            AgreementByAgreementIdMobileRequest = new GetAgreementByAgreementIdMobileRequest();
            AgreementByAgreementIdMobileRequest.agreementId = agreementId;
            AgreementByAgreementIdMobileResponse = null;
            signMobileResponse = null;
            signMobileRequest = new AddAgreementSignMobileRequest();
            imageURLMobileRequest = new ReloadSignatureImageURLMobileRequest();
            imageURLMobileRequest.agreementId = agreementId;
            imageURLMobileRequest.IsCheckIn = false;
            imageURLMobileRequest.isDamageView = false;
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
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Loading agreement details..."));

                    await Task.Run(async () =>
                    {
                        try
                        {
                            //agreementResponse = getAgreementMobile(getAgreementByCustomerIdMobileRequest, token);
                            //customerAgreementModels = agreementResponse.listAgreements;
                            AgreementByAgreementIdMobileResponse = getAgreement(AgreementByAgreementIdMobileRequest, token);
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
                    if (PopupNavigation.Instance.PopupStack.Count > 1)
                    {
                        if (PopupNavigation.Instance.PopupStack[PopupNavigation.Instance.PopupStack.Count - 1].GetType() != typeof(ErrorWithClosePagePopup))
                        {
                            await PopupNavigation.Instance.PopAllAsync();
                        }
                    }

                    if (AgreementByAgreementIdMobileResponse != null && imageURLMobileResponse != null)
                    {
                        if (AgreementByAgreementIdMobileResponse.message.ErrorCode == "200")
                        {
                            AgreementReviewDetailSet agreement = AgreementByAgreementIdMobileResponse.custAgreement;
                            agreementIdEntry.Text = agreement.AgreementDetail.AgreementNumber;
                            string statusString = Enum.GetName(typeof(AgreementStatusConst), agreement.AgreementDetail.Status);
                            statusEntry.Text = statusString;
                            checkOutLocationEntry.Text = agreement.AgreementDetail.CheckoutLocationName;
                            CheckOutDateTimeEntry.Text = agreement.AgreementDetail.CheckoutDate.ToString("MM/dd/yyyy h:mm tt");
                            checkInLocationEntry.Text = agreement.AgreementDetail.CheckinLocationName;
                            checkInDatTimeEntry.Text = agreement.AgreementDetail.CheckinDate.ToString("MM/dd/yyyy h:mm tt");
                            createdDateTimeEntry.Text = ((DateTime)agreement.AgreementDetail.CreatedDate).ToString("MM/dd/yyyy h:mm tt");
                            vehicleEntry.Text = agreement.AgreementDetail.VehicleMakeName + " " + agreement.AgreementDetail.ModelName + " " + agreement.AgreementDetail.Year;
                            VehicleTypeEntry.Text = agreement.AgreementDetail.VehicleType;
                            licenceNoEntry.Text = agreement.AgreementDetail.LicenseNo;
                            NoOfDaysEntry.Text = agreement.AgreementDetail.TotalDays.ToString();
                            totalRentalFee.Text = ((decimal)agreement.AgreementTotal.SubTotal).ToString("0.##");
                            discountEntry.Text = ((decimal)agreement.AgreementDetail.TotalDiscount).ToString("0.##");
                            TotalMiscChargeEntry.Text = ((decimal)agreement.AgreementTotal.TotalMischargeWithOutTax).ToString("0.##");
                            totalTaxChargeEntry.Text = ((decimal)agreement.AgreementTotal.TotalTax).ToString("0.##");
                            grandTotalEntry.Text = ((decimal)agreement.AgreementTotal.TotalAmount).ToString("0.##");
                            advancePaidEntry.Text = ((decimal)agreement.AgreementTotal.AmountPaid).ToString("0.##");
                            balanceDueEntry.Text = ((decimal)agreement.AgreementTotal.BalanceDue).ToString("0.##");
                            //if (agreement.AgreementDetail.SignatureImageUrl != null)
                            //{

                            //    signatureFrame.IsVisible = false;
                            //    signatureGrid.IsVisible = false;
                            //    imageFrame.IsVisible = true;
                            //    //WebClient webClient = new WebClient();

                            //    //byte[] imageBytes = webClient.DownloadData(agreement.AgreementDetail.SignatureImageUrl);


                            //    //FileStream file = new FileStream(agreement.AgreementDetail.SignatureImageUrl, FileMode.Open);

                            //    signatureImage.Source = ImageSource.FromFile(agreement.AgreementDetail.SignatureImageUrl);
                            //}

                            //else if (agreement.AgreementDetail.Status == 2)
                            //{

                            //    signatureFrame.IsVisible = true;
                            //    signatureGrid.IsVisible = true;
                            //}
                            //else
                            //{
                            //    signatureFrame.IsVisible = false;
                            //    signatureGrid.IsVisible = false;
                            //    noSignatureFrame.IsVisible = true;
                            //}
                            //if (agreement.AgreementDetail.Status == 3)
                            //{
                            //    signatureFrame.IsVisible = false;
                            //    signatureGrid.IsVisible = false;
                            //    imageFrame.IsVisible = false;
                            //    noSignatureFrame.IsVisible = false;
                            //}
                            //else 
                            if (imageURLMobileResponse.message.ErrorCode == "200")
                            {
                                if (!string.IsNullOrEmpty(imageURLMobileResponse.SignatureImageUrl))
                                {
                                    signatureFrame.IsVisible = false;
                                    signatureGrid.IsVisible = false;
                                    imageFrame.IsVisible = true;
                                    byte[] Base64Stream = Convert.FromBase64String(imageURLMobileResponse.SignatureImageUrl);
                                    signatureImage.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream));
                                }
                                else if (agreement.AgreementDetail.Status == 2)
                                {

                                    signatureFrame.IsVisible = true;
                                    signatureGrid.IsVisible = true;
                                    imageFrame.IsVisible = false;
                                    noSignatureFrame.IsVisible = false;
                                }
                                else
                                {
                                    signatureFrame.IsVisible = false;
                                    signatureGrid.IsVisible = false;
                                    noSignatureFrame.IsVisible = true;
                                    imageFrame.IsVisible = false;
                                }
                            }
                            else if (agreement.AgreementDetail.Status == 2)
                            {
                                //signatureFrame.IsVisible = false;
                                //signatureGrid.IsVisible = false;
                                //imageFrame.IsVisible = true;
                                //signatureImage.Source = ImageSource.FromUri(new Uri("D:\\Navotar\\Websites\\Images\\Signatures\\Agreement\\158233.jpg"));

                                signatureFrame.IsVisible = true;
                                signatureGrid.IsVisible = true;
                                imageFrame.IsVisible = false;
                                noSignatureFrame.IsVisible = false;
                            }
                            else
                            {
                                signatureFrame.IsVisible = false;
                                signatureGrid.IsVisible = false;
                                noSignatureFrame.IsVisible = true;
                                imageFrame.IsVisible = false;
                            }

                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new ErrorWithClosePagePopup(AgreementByAgreementIdMobileResponse.message.ErrorMessage));
                        }
                    }
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

        private GetAgreementByAgreementIdMobileResponse getAgreement(GetAgreementByAgreementIdMobileRequest agreementByAgreementIdMobileRequest, string token)
        {
            AgreementController agreementController = new AgreementController();
            GetAgreementByAgreementIdMobileResponse response = null;
            try
            {
                response = agreementController.getAgreement(agreementByAgreementIdMobileRequest, token);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        private async void SaveSignatureBtn_Clicked(object sender, EventArgs e)
        {
            bool confirm = await DisplayAlert("Alert", "Are you sure want to save ?", "Yes", "No");
            if (confirm)
            {
                
                signMobileRequest.agreementId = agreementId;
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
                    signMobileRequest.base64Img = strBase64;



                    signMobileResponse = saveSignature(signMobileRequest, token);
                    if (signMobileResponse != null)
                    {
                        if (signMobileResponse.message.ErrorCode == "200")
                        {
                            await PopupNavigation.Instance.PushAsync(new SuccessPopUp("Your signature saved successfully"));
                            signatureView.IsEnabled = false;
                            signatureGrid.IsVisible = false;
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



        private AddAgreementSignMobileResponse saveSignature(AddAgreementSignMobileRequest signMobileRequest, string token)
        {
            AgreementController agreementController = new AgreementController();
            AddAgreementSignMobileResponse response = null;
            try
            {
                response = agreementController.saveSignature(signMobileRequest, token);
            }
            catch (Exception e)
            {
                throw e;
            }
            return response;
        }

        private void HomeBtn_Clicked(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack[Navigation.NavigationStack.Count - 1].GetType() != typeof(HomePage))
            {
                Navigation.PushAsync(new HomePage());
            }
        }

        private void VehiceBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DamageCheckListCheckOut(agreementId, AgreementByAgreementIdMobileResponse.custAgreement.AgreementDetail.AgreementNumber, (int)AgreementByAgreementIdMobileResponse.custAgreement.AgreementDetail.Status, AgreementByAgreementIdMobileResponse.custAgreement.AgreementDetail.VehicleId));


        }

        private void PrintBtn_Clicked(object sender, EventArgs e)
        {
            //MemoryStream lMemoryStream = new MemoryStream();
            //Package package = Package.Open(lMemoryStream, FileMode.Create);
            //XpsDocument doc = new XpsDocument(package);
            //XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);
            //writer.Write(dp);
            //doc.Close();
            //package.Close();
            //var pdfXpsDoc = PdfSharp.Xps.XpsModel.XpsDocument.Open(lMemoryStream);
            //PdfSharp.Xps.XpsConverter.Convert(pdfXpsDoc, d.FileName, 0);
            var pdf = PDFManager.GeneratePDFFromView(myRentals);

        }

        private void ClearSigBtn_Clicked(object sender, EventArgs e)
        {
            signatureView.Clear();
        }

    }
}