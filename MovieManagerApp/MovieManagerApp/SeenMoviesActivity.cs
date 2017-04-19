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
        private List<Movie> movieList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.SeenMoviesLayout);

            //Get list view so can be used
            ListView seenMoviesListView = FindViewById<ListView>(Resource.Id.seenMoviesListView);
            //Fills the list view with data
            FillListView(seenMoviesListView);
            //adds an item click listener and enables fast scroll
            seenMoviesListView.ItemClick += SeenMoviesListView_ItemClick;
            seenMoviesListView.FastScrollEnabled = true;

        }

        /// <summary>
        /// Fills the list view with the relevant data
        /// </summary>
        private void FillListView(ListView seenMoviesListView)
        {
            //Seen Movieslist
            movieList = MovieDatabaseWorker.RetrieveAllMovies();

            //Makes an adapter so data can be put into listView
            MovieListAdapter seenMoviesAdapter = new MovieListAdapter(this, movieList);

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
            MovieInfoFragment infoFragment = new MovieInfoFragment();
            FragmentTransaction ft = FragmentManager.BeginTransaction();
            ft.Add(Resource.Id.movieInfoFragmentContainer, infoFragment);
            ft.Commit();
        }
    }
}