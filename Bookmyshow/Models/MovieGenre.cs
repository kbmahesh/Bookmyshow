using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookmyshow.Models
{
    public class MovieGenre
    {
        [Key]
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }
}
