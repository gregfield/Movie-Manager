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
    public class WebMovieDatabaseWorker
    {
        private string apiKey = "fef48a4fcafe90f6bd87152aa726f7c6";

        /// <summary>
        /// Gets movie info using api call to TMDB on movie title
        /// </summary>
        public void GetMovieInfoUsingTitle(string title)
        {
            //need to figure out how to search on title
            string apiCall = "https://api.themoviedb.org/3/movie/550?api_key=" +
                apiKey + ""; 

            //need to make web request
        }

        /// <summary>
        /// Gets movie info using api call to TMDB on movie id
        /// </summary>
        public void GetMovieInfoUsingID(string title)
        {
            //need to figure out how to search on title
            string apiCall = "https://api.themoviedb.org/3/movie/550?api_key=" +
                apiKey + "";

            //need to make web request
        }
    }
}