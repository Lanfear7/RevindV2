using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace rolesDemoSSD.ViewModels
{
    public class ReviewVM
    {
        [Key]
        public int ReviewID { get; set; }
        public MovieVM MovieVM { get; set; }
        public int MovieID { get; set; }
        public UserVM UserVM { get; set; }
        public string Email { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }
        public string ReviewDate { get; set; }
        public int Rating { get; set; }
        public int Flag { get; set; }

    }
}
