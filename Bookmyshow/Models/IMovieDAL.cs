using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookmyshow.Models
{
    public interface IMovieDAL
    {
        List<Movie> Movies_Select();

        Movie Movie_Select(int id);

        void Movie_Insert(Movie movie);

        void Movie_Update(Movie movie);

        void Movie_Delete(int id);

        List<SelectListItem> GenreList();
    }
}
