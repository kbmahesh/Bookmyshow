using Bookmyshow.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookmyshow.Controllers
{
    public class MovieController : Controller
    {

        private readonly IMovieDAL obj;

        public MovieController(IMovieDAL obj)
        {
            this.obj = obj;
        }
        public ViewResult DisplayMovies()
        {
            
            return View(obj.Movies_Select());
        }

        public ViewResult DisplayMovie(int id)
        {
            return View(obj.Movie_Select(id));
        }

        public ViewResult AddMovie()
        {
            ViewBag.GenreList = obj.GenreList();
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddMovie(Movie movie,IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    imageFile.CopyTo(memoryStream);
                    memoryStream.Position = 0;
                    movie.MovieImage = memoryStream.ToArray();
                }
            }
            obj.Movie_Insert(movie);
            return RedirectToAction("DisplayMovies");
        }

        public ViewResult EditMovie(int id)
        {
            return View(obj.Movie_Select(id));
        }

        public RedirectToActionResult UpdtaeMovie(Movie movie)
        {
            obj.Movie_Update(movie);
            return RedirectToAction("DisplayMovies");
        }

        public RedirectToActionResult DeleteMovie(int id)
        {
            obj.Movie_Delete(id);
            return RedirectToAction("DisplayMovies");
        }
    }
}
