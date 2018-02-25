using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Views;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.Wearable;
using Android.Views.Animations;
using Android.Support.Wearable.Activity;
using Android.Graphics;
using Android.Support.V4.Content;

namespace AndroidWithWear {
	[Activity( Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon" )]
	public class MainActivity : WearableActivity {

		private TrialCounter counter;

		private bool isAmbientMode = false;

		private Button button;

		protected override void OnCreate( Bundle bundle ) {
			base.OnCreate( bundle );

			counter = new TrialCounter();

			// Set our view from the "main" layout resource
			SetContentView( Resource.Layout.Main );

			SetAmbientEnabled();

			button = FindViewById<Button>( Resource.Id.myButton );
			button.Click += ( sender, e ) => {
				counter.CountUp();
				button.Text = $"{counter.Count} times taped.";
			};
		}
	}
}


