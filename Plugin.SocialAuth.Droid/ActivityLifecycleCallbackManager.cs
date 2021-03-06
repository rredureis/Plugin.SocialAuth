﻿using System;
using Android.App;
using Android.OS;
using Android.Support.V4.App;

namespace Plugin.SocialAuth.Droid
{
#pragma warning disable XA0001 // Find issues with Android API usage
	internal class ActivityLifecycleCallbackManager : Java.Lang.Object, global::Android.App.Application.IActivityLifecycleCallbacks
#pragma warning restore XA0001 // Find issues with Android API usage
	{
		public FragmentActivity CurrentActivity { get; private set; }

		public void OnActivityCreated(Activity activity, Bundle savedInstanceState)
		{
			CurrentActivity = activity as FragmentActivity;
		}

		public void OnActivityDestroyed(Activity activity)
		{
			//CurrentActivity = null;
		}

		public void OnActivityPaused(Activity activity)
		{
            CurrentActivity = activity as FragmentActivity;
        }

		public void OnActivityResumed(Activity activity)
		{
			CurrentActivity = activity as FragmentActivity;
		}

		public void OnActivitySaveInstanceState(Activity activity, Bundle outState)
		{
            CurrentActivity = activity as FragmentActivity;
        }

		public void OnActivityStarted(Activity activity)
		{
			CurrentActivity = activity as FragmentActivity;
		}

		public void OnActivityStopped(Activity activity)
		{
            CurrentActivity = activity as FragmentActivity;
        }
	}
}
