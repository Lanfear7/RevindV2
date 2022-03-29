using rolesDemoSSD.Data;
using rolesDemoSSD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rolesDemoSSD.Repositories
{
    public class ReviewRepo
    {
        ApplicationDbContext db;
        public ReviewRepo(ApplicationDbContext context)
        {
            db = context;
        }
        /*public IQueryable<ApplicationDbContext> GetAllReviews()
        {
            var query = from m in db.Reviews
                        select new ReviewVM()
                        {
                            MovieID = m.MovieID,
                            MovieName = m.MovieName,
                            PosterSource = m.PosterSource,
                            Genre = m.Genre,
                            Duration = m.Duration,
                            ReleaseDate = m.ReleaseDate,
                            Distributor = m.Distributor
                        };
            return query;

        }*/
        public bool CreateReview(int movieId, string email, string reviewDate, string reviewContent, int rating, string ratingDate, int flag)
        {
            db.Reviews.Add(new Review
            {
                ReviewContent = reviewContent,
                ReviewDate = reviewDate,
                Rating = rating,
                RatingDate = ratingDate,
                Flag = flag
            });
            db.SaveChanges();
            return true;
        }
    }
}
