using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

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
                    Title = "The Singles Ward",
                    ReleaseDate = DateTime.Parse("2002-01-30"),
                    Genre = "Comedy",
                    Price = 7.99M,
                    Rating = "PG",
                    Image = "singlesward.jpg"
                },
                new Movie
                {
                    Title = "Pride and Prejudice",
                    ReleaseDate = DateTime.Parse("2003-12-05"),
                    Genre = "Romance",
                    Price = 8.99M,
                    Rating = "PG",
                    Image = "pride.jpg"
                },
                new Movie
                {
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-05-31"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating ="PG",
                    Image = "ephraim.jpg"
                },
                new Movie
                {
                    Title = "The Cokeville Miracle",
                    ReleaseDate = DateTime.Parse("2015-05-30"),
                    Genre = "Drama",
                    Price = 3.99M,
                    Rating = "PG-13",
                    Image = "cokeville.jpg"
                },
                new Movie
                {
                    Title = "The Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("2003-04-01"),
                    Genre = "Drama",
                    Price = 9.99M,
                    Rating = "PG",
                    Image = "otherside.jpg"
                },
                new Movie
                {
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("2003-01-31"),
                    Genre = "Comedy",
                    Price = 4.99M,
                    Rating = "PG",
                    Image = "rm.jpg"
                }



            );
            context.SaveChanges();
        }
    }
}
