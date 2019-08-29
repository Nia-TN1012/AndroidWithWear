
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.Wearable.Activity;

namespace AndroidWearApp2 {
    [Activity( Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon" )]
	public class MainActivity : WearableActivity {

		/// <summary>
		///		Counter of shared project.
		/// </summary>
		private TrialCounter counter;

		/// <summary>
		///		Invoked when the activity is first created.
		/// </summary>
		/// <param name="savedInstanceState">Saved instance state</param>
		protected override void OnCreate( Bundle savedInstanceState ) {
			base.OnCreate( savedInstanceState );
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
