using rolesDemoSSD.Data;
using rolesDemoSSD.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace rolesDemoSSD.Repositories
{
    public class MovieRepo
    {
        ApplicationDbContext db;
        public MovieRepo(ApplicationDbContext context)
        {
            db = context;
        }
        public IQueryable<MovieVM> GetAllMovies()
        {
            var query = from m in db.Movies
                        select new MovieVM()
                        {
                            MovieName = m.MovieName,
                            Genre = m.Genre,
                            Duration = m.Duration,
                            ReleaseDate = m.ReleaseDate,
                            Distributor = m.Distributor
                        };
            return query;
                            
        }
      
    }
}
