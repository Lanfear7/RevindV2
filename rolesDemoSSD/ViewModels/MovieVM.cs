using System.ComponentModel.DataAnnotations;

namespace rolesDemoSSD.ViewModels
{
    public class MovieVM
    {
        [Key]
        public int Id { get; set; }
        public string MoviePoster { get; set; }
    }
}
