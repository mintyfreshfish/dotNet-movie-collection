using System;
using System.Collections.Generic;

namespace Assignment3.Models
{
    public static class TempModel
    {
        private static List<MovieFormModel> movies = new List<MovieFormModel>();

        public static IEnumerable<MovieFormModel> Movies => movies;

        public static void AddMovie(MovieFormModel movie)
        {
            movies.Add(movie);
        }
    }
}
