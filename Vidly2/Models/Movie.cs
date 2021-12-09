using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly2.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Display(Name = "Number in stock")]
        public int NumberInStock { get; set; }

        public MovieGenre MovieGenre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte MovieGenreId { get; set; }
    }
}