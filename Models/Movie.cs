using System.ComponentModel.DataAnnotations;

namespace MoviesFinal1406.Models
{

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        public int Year { get; set; }

        public string PosterPath { get; set; }

        [Required]
        public string Description { get; set; }
    }
}