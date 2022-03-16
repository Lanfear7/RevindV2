using System.ComponentModel.DataAnnotations;

namespace rolesDemoSSD.ViewModels
{
    public class MovieVM
    {
        [Key]
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string Duration { get; set; }
        public string ReleaseDate { get; set; }
        public string Distributor { get; set; }
    }
}
