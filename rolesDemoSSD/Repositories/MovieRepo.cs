﻿using rolesDemoSSD.Data;
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
                            MovieID = m.MovieID,
                            MovieName = m.MovieName,
                            PosterSource = m.PosterSource,
                            Genre = m.Genre,
                            Duration = m.Duration,
                            ReleaseDate = m.ReleaseDate,
                            Distributor = m.Distributor
                        };
            return query;
                            
        }

        public MovieVM GetMovieById(int movieID)
        {
            var query = GetAllMovies()
                .Where(mv => mv.MovieID == movieID)
                .FirstOrDefault();
            return query;
        }
      
    }
}
