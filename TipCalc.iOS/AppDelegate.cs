using Foundation;
using UIKit;
using ToDo.Core;
using MvvmCross.Platforms.Ios.Core;
using ToDo.iOS;

namespace TipCalc.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : MvxApplicationDelegate<Setup, App>
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            return result;
        }
    }
}