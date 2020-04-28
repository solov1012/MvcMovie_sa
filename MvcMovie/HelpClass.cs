using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie
{
    public class HelpClass
    {
        public class Result
        {
            public string poster_path { get; set; }
            public string overview { get; set; }
        }
        public class ResponseSearchMovies
        {
            public int page { get; set; }
            public List<Result> results { get; set; }
            public int total_results { get; set; }
            public int total_pages { get; set; }
        }
        public static class MovieList
        {
            public static List<Movie> movies { get; set; }
            static MovieList()
            {
                using (MvcMovieContext context = new MvcMovieContext())
                {
                    movies = context.Movies.ToList();
                }
            }
        }
        public class PageViewModel
        {
            public int PageNumber { get; private set; }
            public int TotalPages { get; private set; }

            public PageViewModel(int count, int pageNumber, int pageSize)
            {
                PageNumber = pageNumber;
                TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            }

            public bool HasPreviousPage
            {
                get
                {
                    return (PageNumber > 1);
                }
            }

            public bool HasNextPage
            {
                get
                {
                    return (PageNumber < TotalPages);
                }
            }
        }
    }
}
