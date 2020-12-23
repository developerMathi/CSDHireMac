using MaxVonGrafKftMobileController;
using MaxVonGrafKftMobileModel;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaxVonGrafKftMobile.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VehicleImagePopup : PopupPage
    {
        private string _base64Image;
        //       private CustomerImages images;
        DateTime UploadedDate;
        public VehicleImage vehicleImage;
        private string token;
        AddfourTypeVehicleImagesResponse addfourTypeVehicleImagesResponse;

        //string PhysicalPath;

        public VehicleImagePopup(string title, VehicleImage vehicleImage)
        {
            InitializeComponent();
            TitleLabel.Text = title;
            this.vehicleImage = vehicleImage;
            token = App.Current.Properties["currentToken"].ToString();
            addfourTypeVehicleImagesResponse = null;

            if (vehicleImage.base64Img != null)
            {
                this._base64Image = vehicleImage.base64Img;
                selectedImage.Source = ImageSource.FromStream(
                () => new MemoryStream(Convert.FromBase64String(_base64Image)));
                PhotoFrame.IsVisible = true;
                SaveBtn.IsVisible = true;
                cancelBtn.IsVisible = true;
                //PhysicalPath = selectedImages.Path;
                UploadedDate = DateTime.Now;
            }
        }

        private async void GaleryBtn_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<CameraPermission>();
            var mediaLibraryStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<MediaLibraryPermission>();
            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<StoragePermission>();

            if (mediaLibraryStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
            {
                mediaLibraryStatus = await CrossPermissions.Current.RequestPermissionAsync<MediaLibraryPermission>();
                storageStatus = await CrossPermissions.Current.RequestPermissionAsync<StoragePermission>();
            }
            if (mediaLibraryStatus == PermissionStatus.Granted && storageStatus == PermissionStatus.Granted)
            {
                
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await DisplayAlert("Not Sopported", "Your device does not currently support this functionality", "OK");
                    return;

                }
                var selectedImages = await CrossMedia.Current.PickPhotoAsync(new PickMediaOptions
                {
                    PhotoSize = PhotoSize.Medium
                });

                if (selectedImages == null)
                {
                    await DisplayAlert("Error", "Could not get the image, Please try again", "Ok");
                    return;
                }
                else
                {
                    // provide read access to the file
                    FileStream fs = new FileStream(selectedImages.Path, FileMode.Open, FileAccess.Read);
                    // Create a byte array of file stream length
                    byte[] ImageData = new byte[fs.Length];
                    //Read block of bytes from stream into the byte array
                    fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
                    //Close the File Stream
                    fs.Close();
                    _base64Image = Convert.ToBase64String(ImageData);


                    //PhotoPath = selectedImage.Path;
                    //                    stream = selectedImage.GetStream();
                    //uploadTime = DateTime.Now;

                    //imageBox.IsVisible = true;
                    selectedImage.Source = ImageSource.FromStream(() => selectedImages.GetStream());
                    PhotoFrame.IsVisible = true;
                    SaveBtn.IsVisible = true;
                    cancelBtn.IsVisible = true;
                    //PhysicalPath = selectedImages.Path;
                    UploadedDate = DateTime.Now;

                }
            }
            else
            {
                await DisplayAlert("Permissions Denied", "Unable to access gallery.", "OK");
                //On iOS you may want to send your user to the settings screen.
                //CrossPermissions.Current.OpenAppSettings();
            }


        }

        private async void cameraBtn_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            var cameraStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<CameraPermission>();
            var storageStatus = await CrossPermissions.Current.CheckPermissionStatusAsync<StoragePermission>();

            if (cameraStatus != PermissionStatus.Granted || storageStatus != PermissionStatus.Granted)
            {
                cameraStatus = await CrossPermissions.Current.RequestPermissionAsync<CameraPermission>();
                storageStatus = await CrossPermissions.Current.RequestPermissionAsync<StoragePermission>();
            }

            if (cameraStatus == PermissionStatus.Granted && storageStatus == PermissionStatus.Granted)
            {



                if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
                {
                    _ = DisplayAlert("No Camera", ":( No camera available.", "OK");

                }


                var files = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    PhotoSize = PhotoSize.Medium,
                    SaveToAlbum = true,
                    ModalPresentationStyle = MediaPickerModalPresentationStyle.OverFullScreen,
                    AllowCropping=true
                });

                if (files == null)
                {

                    return;
                }
                else
                {
                    //imageBox.IsVisible = true;
                    //                    stream = files.GetStream();
                    selectedImage.Source = ImageSource.FromStream(() => files.GetStream());
                    PhotoFrame.IsVisible = true;
                    SaveBtn.IsVisible = true;
                    cancelBtn.IsVisible = true;


                    // provide read access to the file
                    FileStream fs = new FileStream(files.Path, FileMode.Open, FileAccess.Read);
                    // Create a byte array of file stream length
                    byte[] ImageData = new byte[fs.Length];
                    //Read block of bytes from stream into the byte array
                    fs.Read(ImageData, 0, System.Convert.ToInt32(fs.Length));
                    //Close the File Stream
                    fs.Close();
                    //PhysicalPath = files.Path;
                    UploadedDate = DateTime.Now;
                    _base64Image = Convert.ToBase64String(ImageData);
                }

            }
            else
            {
                await DisplayAlert("Permissions Denied", "Unable to take photos.", "OK");
                //On iOS you may want to send your user to the settings screen.
                //CrossPermissions.Current.OpenAppSettings();
            }

        }


        private void cancelBtn_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PopAllAsync();
        }

        private async void SaveBtn_Clicked(object sender, EventArgs e)
        {

            vehicleImage.base64Img = _base64Image;
            AgreementController controller = new AgreementController();

            bool busy = false;
            if (!busy)
            {
                try
                {
                    busy = true;
                    await PopupNavigation.Instance.PushAsync(new LoadingPopup("Updating Vehicle Image"));

                    await Task.Run(() =>
                    {
                        addfourTypeVehicleImagesResponse = controller.addfourTypeVehicleImages(vehicleImage, token);

                    });
                }
                finally
                {
                    if (addfourTypeVehicleImagesResponse.message != null)
                    {
                        if (addfourTypeVehicleImagesResponse.message.ErrorCode == "200")
                        {
                            MessagingCenter.Send(this, "MyItemsChanged");
                            await PopupNavigation.Instance.PushAsync(new SuccessPopUp("Vehicle Image Saved Successfully"));

                        }
                        else
                        {
                            await PopupNavigation.Instance.PushAsync(new Error_popup(addfourTypeVehicleImagesResponse.message.ErrorMessage));
                            vehicleImage.base64Img = null;
                        }
                    }
                    else
                    {
                        await PopupNavigation.Instance.PushAsync(new Error_popup("Image Saving Failed"));
                        vehicleImage.base64Img = null;
                    }

                }

            }

        }

    }
}