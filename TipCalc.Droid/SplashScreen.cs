using Android.App;
using Android.Content.PM;
using MvvmCross.Platforms.Android.Views;


namespace ToDo.Droid
{
    [Activity(
        MainLauncher = true,
        Icon = "@drawable/icon",
        Theme = "@style/Theme.Splash",
        NoHistory = true,
        ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(TipCalc.UI.Droid.Resource.Layout.SplashScreen)
        {
        }
    }
}