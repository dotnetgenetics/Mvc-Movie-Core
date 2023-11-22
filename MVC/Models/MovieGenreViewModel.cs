using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC.Models
{
    public class MovieGenreViewModel
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();
        public SelectList Genres { get; set; } 
        public string MovieGenre { get; set; } = string.Empty;
        public string SearchString { get; set; } = string.Empty;
    }
}
