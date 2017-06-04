using Android.App;
using Android.Widget;
using Android.OS;

namespace Xamarin.Wallet
{
    [Activity(Label = "Xamarin.Wallet", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Initialization for Azure Mobile Apps
            Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
            // This MobileServiceClient has been configured to communicate with the Azure Mobile App and
            // Azure Gateway using the application url. You're all set to start working with your Mobile App!
            Microsoft.WindowsAzure.MobileServices.MobileServiceClient vctWallClient = new Microsoft.WindowsAzure.MobileServices.MobileServiceClient(
            "http://vctwall.azurewebsites.net");

            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

