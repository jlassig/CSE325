using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMovie.Data;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Home Alone",
                        ReleaseDate = DateTime.Parse("1990-11-16"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "The Lion King",
                        ReleaseDate = DateTime.Parse("1994-06-15"),
                        Genre = "Animation",
                        Price = 12.99M,
                        Rating = "G"
                    },
                    new Movie
                    {
                        Title = "Jurassic Park",
                        ReleaseDate = DateTime.Parse("1993-06-11"),
                        Genre = "Sci-Fi",
                        Price = 10.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "E.T. the Extra-Terrestrial",
                        ReleaseDate = DateTime.Parse("1982-06-11"),
                        Genre = "Sci-Fi",
                        Price = 7.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Crazy, Stupid, Love",
                        ReleaseDate = DateTime.Parse("2011-07-29"),
                        Genre = "Romantic Comedy",
                        Price = 7.50M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Harry Potter",
                        ReleaseDate = DateTime.Parse("2001-11-14"),
                        Genre = "Fantasy",
                        Price = 8.99M,
                        Rating = "PG"
                    }


                );
                context.SaveChanges();
            }
        }
    }
}
