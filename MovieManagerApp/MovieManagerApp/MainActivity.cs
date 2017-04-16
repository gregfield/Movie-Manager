using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace MovieManagerApp
{
    [Activity(Label = "MovieManagerApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //Initilise Buttons
            Button newRandBtn = FindViewById<Button>(Resource.Id.NewRandBtn);
            Button viewAlreadySeenBtn = FindViewById<Button>(Resource.Id.AlreadyWatchedBtn);

            //Adds the Click handlers to the buttons
            newRandBtn.Click += NewRandBtn_Click;
            viewAlreadySeenBtn.Click += ViewAlreadySeenBtn_Click;
        }

        /// <summary>
        /// Button click handler for getting a new random movie.
        /// Creates new activity and sends user to it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewRandBtn_Click(object sender, System.EventArgs e)
        {
            //Make new Intent
            Intent randMovieIntent = new Intent(this, typeof(RandMovieActivity));
            //Start Activity
            StartActivity(randMovieIntent);
        }

        /// <summary>
        /// Button click handler for View the already seen movies.
        /// Creates an information fragment with movie information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewAlreadySeenBtn_Click(object sender, System.EventArgs e)
        {
            //Make new Intent
            Intent seenMoviesIntent = new Intent(this, typeof(SeenMoviesActivity));
            //Start Activity
            StartActivity(seenMoviesIntent);
        }
    }
}

