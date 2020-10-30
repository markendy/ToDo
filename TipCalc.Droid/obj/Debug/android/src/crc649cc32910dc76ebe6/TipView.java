package crc649cc32910dc76ebe6;


public class TipView
	extends crc6466d8e86b1ec8bfa8.MvxActivity_1
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ToDo.Droid.Views.TipView, TipCalc.UI.Droid", TipView.class, __md_methods);
	}


	public TipView ()
	{
		super ();
		if (getClass () == TipView.class)
			mono.android.TypeManager.Activate ("ToDo.Droid.Views.TipView, TipCalc.UI.Droid", "", this, new java.lang.Object[] {  });
	}


	public TipView (int p0)
	{
		super (p0);
		if (getClass () == TipView.class)
			mono.android.TypeManager.Activate ("ToDo.Droid.Views.TipView, TipCalc.UI.Droid", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
