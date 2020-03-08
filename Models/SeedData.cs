using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        MovieGenre = Movie.Genre.Romance,
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("2001-12-14"),
                        MovieGenre = Movie.Genre.Drama,
                        Rating = "PG",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven 2",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        MovieGenre = Movie.Genre.Drama,
                        Rating = "PG-13",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Meet the Mormons",
                        ReleaseDate = DateTime.Parse("2019-6-28"),
                        MovieGenre = Movie.Genre.Documentary,
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Best Two Years",
                        ReleaseDate = DateTime.Parse("2004-2-20"),
                        MovieGenre = Movie.Genre.Comedy,
                        Rating = "PG",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}