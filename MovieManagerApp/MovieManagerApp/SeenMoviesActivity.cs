using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MovieManagerApp
{
    [Activity(Label = "Seen Movies Activity")]
    public class SeenMoviesActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SeenMoviesLayout);

            //Get list view so can be used
            ListView seenMoviesListView = FindViewById<ListView>(Resource.Id.seenMoviesListView);
            //Fills the list view with data
            FillListView(seenMoviesListView);
            //adds an item click listener
            seenMoviesListView.ItemClick += SeenMoviesListView_ItemClick;
            
        }

        /// <summary>
        /// Fills the list view with the relevant data
        /// </summary>
        private void FillListView(ListView seenMoviesListView)
        {
            //Seen Movieslist
            string[] movieslist = { "fast and furious 1", "fast and furious 2",
                "fast and furious 3", "fast and furious 4", "fast and furious 5" };

            //Makes and adapter so data can be put into listView
            ArrayAdapter<string> seenMoviesAdapter = new ArrayAdapter<string>(this, 
                Resource.Layout.ListViewLayout, Resource.Id.movieTitle, movieslist);

            //Gets the listview and sets the adapter
            seenMoviesListView.Adapter = seenMoviesAdapter;
        }

        /// <summary>
        /// Decides what happens when an item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SeenMoviesListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, e.Position.ToString(), ToastLength.Short).Show();
        }
    }
}