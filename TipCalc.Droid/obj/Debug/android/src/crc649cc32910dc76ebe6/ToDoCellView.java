package crc649cc32910dc76ebe6;


public class ToDoCellView
	extends mvvmcross.platforms.android.binding.views.MvxListItemView
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("ToDo.Droid.Views.ToDoCellView, TipCalc.UI.Droid", ToDoCellView.class, __md_methods);
	}


	public ToDoCellView ()
	{
		super ();
		if (getClass () == ToDoCellView.class)
			mono.android.TypeManager.Activate ("ToDo.Droid.Views.ToDoCellView, TipCalc.UI.Droid", "", this, new java.lang.Object[] {  });
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
