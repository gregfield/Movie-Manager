using System;
using System.IO;
using System.Collections.Generic;

using SQLite;

namespace MovieManagerApp
{
    public static class MovieDatabaseWorker
    {
        private static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "DBmovies.db3");

        /// <summary>
        /// Makes Database and fills with random data for testing purposes
        /// </summary>
        /// <returns></returns>
        public static void MakeTestDB()
        {
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie(1, "fast and furious 1"));
            movieList.Add(new Movie(2, "fast and furious 2", 5));
            movieList.Add(new Movie(3, "fast and furious 3"));
            movieList.Add(new Movie(4, "fast and furious 4", 4));
            movieList.Add(new Movie(5, "fast and furious 5"));
            movieList.Add(new Movie(6, "fast and furious 6", 7));
            movieList.Add(new Movie(7, "fast and furious 7", 10));
            
            foreach(Movie m in movieList)
            {
                AddMovieToDatabase(m);
            }
        }

        /// <summary>
        /// Adds a new movie object to the database
        /// </summary>
        /// <param name="movieToAdd"></param>
        /// <returns></returns>
        public static bool AddMovieToDatabase(Movie movieToAdd)
        {
            try
            {
                //Connect to database
                var dbMovies = new SQLiteConnection(path);
                //Connect to table
                dbMovies.CreateTable<Movie>();
                //insert movie item into database
                dbMovies.Insert(movieToAdd);
                //close database connection
                dbMovies.Close();
                //return succesful
                return true;
            }
            catch(SQLiteException ex)
            {
                //return unsuccesful
                return false;
            }
        }

        /// <summary>
        /// Retrieves all the movies from the database
        /// </summary>
        /// <returns></returns>
        public static List<Movie> RetrieveAllMovies()
        {
            List<Movie> databaseMovies = new List<Movie>();
            //Connect to database
            var dbMovies = new SQLiteConnection(path);
            //connect to table
            var movieTable = dbMovies.Table<Movie>();

            //gets all the movies out of the table and adds them to the list
            foreach(var movie in movieTable)
            {
                databaseMovies.Add(new Movie(movie.movieId, movie.movieTitle, movie.rating));
            }

            //close database connection
            dbMovies.Close();

            return databaseMovies;
        }
    }
}