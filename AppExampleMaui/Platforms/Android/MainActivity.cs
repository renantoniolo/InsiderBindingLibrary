using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Useinsider.Insider;

namespace AppExampleMaui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Initialize the Insider SDK in Android context
        //Insider.Instance.Init((Android.App.Application?)Android.App.Application.Context.ApplicationContext, "caaqui");
    }
}