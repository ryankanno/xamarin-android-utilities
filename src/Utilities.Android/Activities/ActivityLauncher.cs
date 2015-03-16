namespace Utilities.Android.Activities
{
	using global::Android.App;
	using global::Android.Content;
	using global::Android.OS;
	using Java.Lang;
	using System;

	public sealed class ActivityLauncher
	{
		private readonly Activity activity;

		public ActivityLauncher (Activity launcher)
		{
			if (null == launcher)
			{
				throw new ArgumentNullException ("launcher");
			}
			this.activity = launcher;
		}

		public void startActivity (Intent intent, int delayMillis = 0)
		{
			new Handler ().PostDelayed (new Runnable (delegate {
				this.activity.StartActivity (intent);
				this.activity.Finish ();
			}), delayMillis);
		}
	}
} 