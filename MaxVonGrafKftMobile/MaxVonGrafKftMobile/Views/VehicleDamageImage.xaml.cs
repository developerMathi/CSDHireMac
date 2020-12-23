using MaxVonGrafKftMobile.Popups;
using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using Rg.Plugins.Popup.Services;
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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleDamageImage : ContentPage
    {
        public static VehicleImage frontStaticImage;
        public static VehicleImage rearStaticImage;
        public static VehicleImage leftStaticImage;
        public static VehicleImage rightStaticImage;

        //new
        LoadvehicleViewImagesReq loadvehicleViewImagesReq;
        LoadvehicleViewImagesResponse response;
        AgreementController agreementController;


        int agreementId;
        int clientId;
        int VehicleId;
        int customerId;
        private string token;
        string AgreementNumber;
        string InoutStatus;

        public VehicleDamageImage(int agreementId, string AgreementNumber, int VehicleId, string InoutStatus)
        {
            InitializeComponent();
            frontStaticImage = new VehicleImage();
            rearStaticImage = new VehicleImage();
            leftStaticImage = new VehicleImage();
            rightStaticImage = new VehicleImage();

            //new
            agreementController = new AgreementController();
            loadvehicleViewImagesReq = new LoadvehicleViewImagesReq();
            response = null;


            var assembly = typeof(VehicleDamageImage);
            FrontImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.Front.png", assembly);
            RearImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.back.png", assembly);
            LeftImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.side1.png", assembly);
            RightImage.Source = ImageSource.FromResource("MaxVonGrafKftMobile.Assets.side2.png", assembly);
            this.agreementId = agreementId;
            token = App.Current.Properties["currentToken"].ToString();
            clientId = Constants.ClientId;
            customerId = int.Parse(App.Current.Properties["CustomerId"].ToString());
            this.AgreementNumber = AgreementNumber;
            this.VehicleId = VehicleId;
            loadvehicleViewImagesReq.AgreementID = agreementId;
            loadvehicleViewImagesReq.clientId = clientId;
            this.InoutStatus = InoutStatus;
            if (InoutStatus == "out")
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                frontStaticImage.customerId = customerId;
                frontStaticImage.clientId = clientId;
                frontStaticImage.agreementId = agreementId;
                frontStaticImage.agreementNo = AgreementNumber;
                frontStaticImage.imageView = "frontViewOut";
                frontStaticImage.vehicleId = VehicleId;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                rearStaticImage.customerId = customerId;
                rearStaticImage.clientId = clientId;
                rearStaticImage.agreementId = agreementId;
                rearStaticImage.agreementNo = AgreementNumber;
                rearStaticImage.vehicleId = VehicleId;
                rearStaticImage.imageView = "rearViewOut";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                leftStaticImage.customerId = customerId;
                leftStaticImage.clientId = clientId;
                leftStaticImage.agreementId = agreementId;
                leftStaticImage.agreementNo = AgreementNumber;
                leftStaticImage.vehicleId = VehicleId;
                leftStaticImage.imageView = "leftViewOut";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                rightStaticImage.customerId = customerId;
                rightStaticImage.clientId = clientId;
                rightStaticImage.agreementId = agreementId;
                rightStaticImage.agreementNo = AgreementNumber;
                rightStaticImage.vehicleId = VehicleId;
                rightStaticImage.imageView = "rightViewOut";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            if (InoutStatus == "in")
            {
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                frontStaticImage.customerId = customerId;
                frontStaticImage.clientId = clientId;
                frontStaticImage.agreementId = agreementId;
                frontStaticImage.agreementNo = AgreementNumber;
                frontStaticImage.imageView = "frontViewIn";
                frontStaticImage.vehicleId = VehicleId;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                rearStaticImage.customerId = customerId;
                rearStaticImage.clientId = clientId;
                rearStaticImage.agreementId = agreementId;
                rearStaticImage.agreementNo = AgreementNumber;
                rearStaticImage.vehicleId = VehicleId;
                rearStaticImage.imageView = "rearViewIn";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                leftStaticImage.customerId = customerId;
                leftStaticImage.clientId = clientId;
                leftStaticImage.agreementId = agreementId;
                leftStaticImage.agreementNo = AgreementNumber;
                leftStaticImage.vehicleId = VehicleId;
                leftStaticImage.imageView = "leftViewIn";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                rightStaticImage.customerId = customerId;
                rightStaticImage.clientId = clientId;
                rightStaticImage.agreementId = agreementId;
                rightStaticImage.agreementNo = AgreementNumber;
                rightStaticImage.vehicleId = VehicleId;
                rightStaticImage.imageView = "rightViewIn";
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }




            var frontImageTap = new TapGestureRecognizer();
            frontImageTap.Tapped += (s, e) =>
           {
               PopupNavigation.Instance.PushAsync(new VehicleImagePopup("Front Image", frontStaticImage));
           };
            FrontImageFrame.GestureRecognizers.Add(frontImageTap);
            FrontImage.GestureRecognizers.Add(frontImageTap);


            var RearImageTap = new TapGestureRecognizer();
            RearImageTap.Tapped += (s, e) =>
            {
                PopupNavigation.Instance.PushAsync(new VehicleImagePopup("Rear Image", rearStaticImage));
            };
            RearImageFrame.GestureRecognizers.Add(RearImageTap);
            RearImage.GestureRecognizers.Add(RearImageTap);

            var LeftImageTap = new TapGestureRecognizer();
            LeftImageTap.Tapped += (s, e) =>
            {
                PopupNavigation.Instance.PushAsync(new VehicleImagePopup("Left Image", leftStaticImage));
            };
            LeftImageFrame.GestureRecognizers.Add(LeftImageTap);
            LeftImage.GestureRecognizers.Add(LeftImageTap);

            var RightImageTap = new TapGestureRecognizer();
            RightImageTap.Tapped += (s, e) =>
            {
                PopupNavigation.Instance.PushAsync(new VehicleImagePopup("Right Image", rightStaticImage));
            };
            RightImageFrame.GestureRecognizers.Add(RightImageTap);
            RightImage.GestureRecognizers.Add(RightImageTap);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();


            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Updating Vehicle Images"));

                    await Task.Run(() =>
                    {
                        if (InoutStatus == "out")
                        {
                            response = agreementController.loadvehicleViewImages(loadvehicleViewImagesReq, token);
                        }
                        if (InoutStatus == "in")
                        {
                            response = agreementController.loadvehicleViewImagesCheckIn(loadvehicleViewImagesReq, token);
                        }
                    });
                }
                finally
                {
                    busy = false;
                    await PopupNavigation.Instance.PopAsync();

                    if (response != null)
                    {

                        if (response.message.ErrorCode == "200")
                        {
                            if (response.imageArray[0].ToString() != "NotFound")
                            {
                                frontStaticImage.base64Img = response.imageArray[0];
                            }
                            if (response.imageArray[1].ToString() != "NotFound")
                            {
                                rearStaticImage.base64Img = response.imageArray[1];
                            }
                            if (response.imageArray[2].ToString() != "NotFound")
                            {
                                leftStaticImage.base64Img = response.imageArray[2];
                            }
                            if (response.imageArray[3].ToString() != "NotFound")
                            {
                                rightStaticImage.base64Img = response.imageArray[3];
                            }

                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup(response.message.ErrorMessage));
                        }

                        //if (InoutStatus == "in")
                        //{
                        //    if (response.message.ErrorCode == "200")
                        //    {
                        //        if (response.imageArray.Count > 4)
                        //        {
                        //            if (response.imageArray[4].ToString() != "NotFound")
                        //            {
                        //                frontStaticImage.base64Img = response.imageArray[4];
                        //            }
                        //            if (response.imageArray[5].ToString() != "NotFound")
                        //            {
                        //                rearStaticImage.base64Img = response.imageArray[5];
                        //            }
                        //            if (response.imageArray[6].ToString() != "NotFound")
                        //            {
                        //                leftStaticImage.base64Img = response.imageArray[6];
                        //            }
                        //            if (response.imageArray[7].ToString() != "NotFound")
                        //            {
                        //                rightStaticImage.base64Img = response.imageArray[7];
                        //            }
                        //        }


                        //    }
                        //    else
                        //    {
                        //        await PopupNavigation.Instance.PushAsync(new Error_popup(response.message.ErrorMessage));
                        //    }


                        //}

                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new Error_popup("Error. Please check your internet connection"));
                    }

                }

            }




            if (frontStaticImage.base64Img != null)
            {
                FrontImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(frontStaticImage.base64Img)));
            }
            if (rearStaticImage.base64Img != null)
            {
                RearImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(rearStaticImage.base64Img)));
            }
            if (leftStaticImage.base64Img != null)
            {
                LeftImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(leftStaticImage.base64Img)));
            }
            if (rightStaticImage.base64Img != null)
            {
                RightImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(rightStaticImage.base64Img)));
            }

            MessagingCenter.Subscribe<VehicleImagePopup>(this, "MyItemsChanged", sender =>
            {
                if (frontStaticImage.base64Img != null)
                {
                    FrontImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(frontStaticImage.base64Img)));
                }
                if (rearStaticImage.base64Img != null)
                {
                    RearImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(rearStaticImage.base64Img)));
                }
                if (leftStaticImage.base64Img != null)
                {
                    LeftImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(leftStaticImage.base64Img)));
                }
                if (rightStaticImage.base64Img != null)
                {
                    RightImage.Source = ImageSource.FromStream(() => new MemoryStream(Convert.FromBase64String(rightStaticImage.base64Img)));
                }
            });

        }

        private void continueBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        
    }


}