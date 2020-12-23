
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using ContextMenu.Droid;
using DLToolkit.Forms.Controls;
using PanCardView.Droid;
using Plugin.CurrentActivity;
using Plugin.Permissions;

namespace MaxVonGrafKftMobile.Droid
{
    [Activity(Label = "MaxVonGrafKftMobile", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            FlowListView.Init();
            base.OnCreate(savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);
            ContextMenuViewRenderer.Preserve();
            Plugin.InputKit.Platforms.Droid.Config.Init(this, savedInstanceState);
            global::Xamarin.Forms.FormsMaterial.Init(this, savedInstanceState);
            string pagename = null;
            string data = null;
            if (Intent.Extras != null)
            {
                pagename = Intent.GetStringExtra("PageName") ?? string.Empty;
                data = Intent.GetStringExtra("Data") ?? string.Empty;
            }
            CardsViewRenderer.Preserve();
            //if (Intent.Extras != null)
            //{
            //    if (!App.Current.Properties.ContainsKey("NotificationPage"))
            //    {
            //        pagename = null;
            //    }
            //    else
            //    {
            //        pagename= App.Current.Properties["NotificationPage"].ToString();
            //    }

            //    if (!App.Current.Properties.ContainsKey("notificationData"))
            //    {
            //        data = null;
            //    }
            //    else
            //    {
            //        data = App.Current.Properties["notificationData"].ToString();
            //    }
            //}
            LoadApplication(new App(pagename, data));
        }


        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}