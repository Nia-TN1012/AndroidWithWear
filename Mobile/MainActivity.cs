using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidWithWear {

	[Activity( Label = "Mobile", MainLauncher = true )]
	public class MainActivity : Activity {

		/// <summary>
		///		Counter of shared project.
		/// </summary>
		public TrialCounter counter;

		/// <summary>
		///		Invoked when the activity is first created.
		/// </summary>
		/// <param name="bundle">Saved instance state</param>
		protected override void OnCreate( Bundle bundle ) {
			base.OnCreate( bundle );

			counter = new TrialCounter();

			// Set our view from the "main" layout resource
			SetContentView( Resource.Layout.Main );

			// Sets button's click event.
			var button = FindViewById<Button>( Resource.Id.myButton );
			button.Click += ( sender, e ) => {
				counter.CountUp();
				button.Text = $"{counter.Count} times tapped.";
			};
		}
	}
}

