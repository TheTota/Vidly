using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly2.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberInStock { get; set; }
        [Required]
        public MovieGenre MovieGenre { get; set; }
        public byte MovieGenreId { get; set; }
    }
}