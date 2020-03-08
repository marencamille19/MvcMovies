using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Genre")]
        public Genre MovieGenre { get; set; }

        [Column(TypeName = "decimal(18, 2")]
        public decimal Price { get; set; }

        public string Rating { get; set; }

        public enum Genre
        {
            Documentary,
            Romance,
            Comedy,
            Drama
        }
    }
}