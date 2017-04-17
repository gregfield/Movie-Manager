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
    class MovieListAdapter : BaseAdapter<Movie>
    {
        List<Movie> movieList;
        Context context;

        public MovieListAdapter(Context context, List<Movie> movieList)
        {
            this.context = context;
            this.movieList = movieList;
        }

        public override Movie this[int position]
        {
            get{ return movieList[position]; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get{ return movieList.Count; }
        }

        /// <summary>
        /// Custom View for adapter
        /// </summary>
        /// <param name="position"></param>
        /// <param name="convertView"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;

            if(view == null)
            {
                LayoutInflater inflater = LayoutInflater.From(context);
                view = inflater.Inflate(Resource.Layout.ListViewLayout, null, false);
            }

            //var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
            //replace with your item and your holder items
            //comment back in
            ///view = inflater.Inflate(Resource.Layout.ListViewLayout, parent, false);
            TextView title = view.FindViewById<TextView>(Resource.Id.movieTitle);
            TextView rating = view.FindViewById<TextView>(Resource.Id.movieRating);
            title.Text = movieList[position].movieTitle;
            rating.Text = movieList[position].rating.ToString();

            //fill in your items
            //holder.Title.Text = "new text here";

            return view;
        }
    }
}