package mono.android.app;

public class ApplicationRegistration {

	public static void registerApplications ()
	{
				// Application and Instrumentation ACWs must be registered first.
		mono.android.Runtime.register ("ToDo.Droid.MainApplication, TipCalc.UI.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", crc6410b21de4dc7847a5.MainApplication.class, crc6410b21de4dc7847a5.MainApplication.__md_methods);
		mono.android.Runtime.register ("MvvmCross.Platforms.Android.Views.MvxAndroidApplication, MvvmCross, Version=7.0.0.0, Culture=neutral, PublicKeyToken=null", crc6466d8e86b1ec8bfa8.MvxAndroidApplication.class, crc6466d8e86b1ec8bfa8.MvxAndroidApplication.__md_methods);
		mono.android.Runtime.register ("MvvmCross.Platforms.Android.Views.MvxAndroidApplication`2, MvvmCross, Version=7.0.0.0, Culture=neutral, PublicKeyToken=null", crc6466d8e86b1ec8bfa8.MvxAndroidApplication_2.class, crc6466d8e86b1ec8bfa8.MvxAndroidApplication_2.__md_methods);
		
	}
}
