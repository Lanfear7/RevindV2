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
        public IQueryable<ReviewVM> GetAllReviews(int movieId)
        {
            var movieQuery = (from m in db.Movies
                              where m.MovieID == movieId
                              select m).FirstOrDefault();
            var query = from r in db.Reviews
                        where r.MovieID == movieQuery.MovieID
                        select new ReviewVM()
                        {
                            MovieID = movieQuery.MovieID
                        };
            return query;

        }
        public bool CreateReview(int movieId, string reviewTitle, string email, string reviewDate, string reviewContent, int rating, string ratingDate, int flag)
        {
            db.Reviews.Add(new Review
            {
                MovieID = movieId,
                ReviewTitle = reviewTitle,
                Email = email,
                ReviewContent = reviewContent,
                ReviewDate = reviewDate,
                Rating = rating,
                RatingDate = ratingDate,
                Flag = flag
            });
            db.SaveChanges();
            return true;
        }
        public Review EditReviewById(int id)
        {
            var query = db.Reviews.FirstOrDefault(r => r.ReviewID == id);

            return query;
        }
        public Review DeleteReviewById(int id)
        {
            var query = db.Reviews.FirstOrDefault(r => r.ReviewID == id);
            db.Remove(query);
            db.SaveChanges();
            return query;
        }
    }
}
