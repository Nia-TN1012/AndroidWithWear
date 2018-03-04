using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Support.Wearable;
using Android.Views.Animations;
using Android.Support.Wearable.Activity;
using Android.Graphics;
using Android.Support.V4.Content;
using Android.Support.V4.Widget;

namespace AndroidWithWear.Wear {
	[Activity( Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon" )]
	public class MainActivity : WearableActivity {

		/// <summary>
		///		Counter of shared project.
		/// </summary>
		private TrialCounter counter;

		/// <summary>
		///		Invoked when the activity is first created.
		/// </summary>
		/// <param name="bundle">Saved instance state</param>
		protected override void OnCreate( Bundle bundle ) {
			base.OnCreate( bundle );
			counter = new TrialCounter();

			// Set our view from the "main" layout resource
			SetContentView( Resource.Layout.Main );

			SetAmbientEnabled();

			// Sets button's click event.
			var textView = FindViewById<TextView>( Resource.Id.myTextView );
			var imageButton = FindViewById<ImageButton>( Resource.Id.myImageButton );
			imageButton.Click += ( sender, e ) => {
				counter.CountUp();
				textView.Text = $"{counter.Count} times tapped.";
			};
		}
	}
}