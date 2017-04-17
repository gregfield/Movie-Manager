namespace MovieManagerApp
{
    public class Movie
    {

        public int movieId { get; set; }
        public string movieTitle { get; set; }
        public int rating { get; set; }

        public Movie()
        { }

        /// <summary>
        /// Make new Movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="movieTitle"></param>
        public Movie(int movieId, string movieTitle)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
        }

        /// <summary>
        /// Make new Movie
        /// </summary>
        /// <param name="movieId"></param>
        /// <param name="movieTitle"></param>
        /// <param name="rating"></param>
        public Movie(int movieId, string movieTitle, int rating)
        {
            this.movieId = movieId;
            this.movieTitle = movieTitle;
            this.rating = rating;
        }

        public override string ToString()
        {
            return movieTitle + " got a rating of " + rating;
        }
    }
}