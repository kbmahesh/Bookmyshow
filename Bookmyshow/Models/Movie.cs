using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bookmyshow.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [MaxLength(30)]
        [Column(TypeName="Varchar")]
        public string MovieName { get; set; }
        public byte[] MovieImage {  get; set; }
        public string Genre {  get; set; }
        public bool Status { get; set; }
    }
}
