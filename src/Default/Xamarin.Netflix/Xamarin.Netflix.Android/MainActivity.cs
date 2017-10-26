using Android.App;
using Android.Content.PM;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms.Droid;
using Xamarin.Netflix.ViewModels.Base;
using FormsToolkit;

namespace Xamarin.Netflix.Droid
{
    [Activity (Label = "Xamarin.Netflix", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.ToolbarLogo;

            base.OnCreate(bundle);

            CachedImageRenderer.Init();

            Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            // Remove the logo when we're not on the main page.
            MessagingService.Current.Subscribe<bool>(MessageKeys.ChangeToolbar, (page, showLogo) =>
            {
                var logo = FindViewById<ImageView>(Resource.Id.logoImageLayout);

                if (showLogo)
                {
                    logo.Visibility = ViewStates.Visible;
                }
                else
                {
                    logo.Visibility = ViewStates.Invisible;
                }
            });
        }
    }
}