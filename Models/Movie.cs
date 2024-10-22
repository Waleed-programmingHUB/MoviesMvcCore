using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesMvcCore.Models
{
    public class Movie
    {
        // Id of the movie
        public int Id { get; set; }
        // Title of the movie
        [DataType(DataType.Text)]
        public string? MovieTitle { get; set; }
        // URL of the movie
        [Required]
        [DataType(DataType.Url)]
        [RegularExpression(@"https://www.youtube.com/\?v=[a-zA-Z0-9-_]+")]
        [StringLength(60)]
        public string? MovieUrl { get; set; }
        // Genre of the movie
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [StringLength(30)]
        public string? Genre { get; set; }
        // Date of release
        [DataType(DataType.Date)]
        public DateTime DateOfRelease { get; set; }
        // Price of the movie
        [Column(TypeName = "decimal(18, 2)")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        // Rating of the movie
        public string? Rating { get; set; }

        // Created at
        [DataType(DataType.Date)]
        public DateTime createAt { get; set; }
    }
}
