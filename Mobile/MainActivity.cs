using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidWithWear {

	[Activity( Label = "Mobile", MainLauncher = true )]
	public class MainActivity : Activity {

		public TrialCounter counter;

		protected override void OnCreate( Bundle savedInstanceState ) {
			base.OnCreate( savedInstanceState );

			counter = new TrialCounter();

			// Set our view from the "main" layout resource
			SetContentView( Resource.Layout.Main );

			var button = FindViewById<Button>( Resource.Id.myButton );
			button.Click += ( sender, e ) => {
				counter.CountUp();
				button.Text = $"{counter.Count} times taped.";
			};
		}
	}
}

