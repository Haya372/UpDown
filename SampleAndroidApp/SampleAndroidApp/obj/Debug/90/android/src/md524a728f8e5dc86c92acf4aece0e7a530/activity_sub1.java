package md524a728f8e5dc86c92acf4aece0e7a530;


public class activity_sub1
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("SampleAndroidApp.activity_sub1, SampleAndroidApp", activity_sub1.class, __md_methods);
	}


	public activity_sub1 ()
	{
		super ();
		if (getClass () == activity_sub1.class)
			mono.android.TypeManager.Activate ("SampleAndroidApp.activity_sub1, SampleAndroidApp", "", this, new java.lang.Object[] {  });
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
