using Microsoft.AspNetCore.Mvc.Rendering;
using MoviesMvcCore.Models;

namespace MoviesMvcCore.MVVM
{
    public class MovieGenreViewModel
    {
        public List<Movie>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? searchString { get; set; }
    }
}
