using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookmyshow.Models
{
    public class MovieSqlDAL:IMovieDAL
    {
        private readonly BookDBContext context;

        public MovieSqlDAL(BookDBContext context)
        {
            this.context = context;
        }
        public List<Movie> Movies_Select()
        {
            var Movies = context.Movies.Where(M => M.Status == true).ToList();
            return Movies;
        }

        public Movie Movie_Select(int id)
        {
            var Movie = context.Movies.Find(id);
            return Movie;
        }

        public void Movie_Insert(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void Movie_Update(Movie movie)
        {
            movie.Status = true;
            context.Update(movie);
            context.SaveChanges();
        }

        public void Movie_Delete(int id)
        {
            Movie movie = context.Movies.Find(id);
            movie.Status = false;
            context.SaveChanges();
        }

        public List<SelectListItem> GenreList()
        {
            var GenreListItems = context.Genres.Select(MovieGenre => new SelectListItem() { Value = MovieGenre.GenreName, Text = MovieGenre.GenreName }).ToList();
            return GenreListItems;
        }
    }
}
