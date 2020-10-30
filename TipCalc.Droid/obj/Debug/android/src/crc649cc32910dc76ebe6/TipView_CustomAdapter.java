package crc649cc32910dc76ebe6;


public class TipView_CustomAdapter
	extends crc6485901dbe4555b529.MvxAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ToDo.Droid.Views.TipView+CustomAdapter, TipCalc.UI.Droid", TipView_CustomAdapter.class, __md_methods);
	}


	public TipView_CustomAdapter ()
	{
		super ();
		if (getClass () == TipView_CustomAdapter.class)
			mono.android.TypeManager.Activate ("ToDo.Droid.Views.TipView+CustomAdapter, TipCalc.UI.Droid", "", this, new java.lang.Object[] {  });
	}

	public TipView_CustomAdapter (android.content.Context p0)
	{
		super ();
		if (getClass () == TipView_CustomAdapter.class)
			mono.android.TypeManager.Activate ("ToDo.Droid.Views.TipView+CustomAdapter, TipCalc.UI.Droid", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
