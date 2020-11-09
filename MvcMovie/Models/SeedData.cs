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

                // Look for any genres
                /*if (context.Genre.Any())
                {
                    return;
                }

                context.Genre.AddRange(
                    new Genre
                    {
                        Description = "Romantic Comedy"
                    },

                    new Genre
                    {
                        Description = "History"
                    },

                    new Genre
                    {
                        Description = "Adventure"
                    },

                    new Genre
                    {
                        Description = "Reality"
                    }
                );*/

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Charlie",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = new Genre
                        {
                            Description = "Romantic Comedy"
                        },
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Book of Mormon",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = new Genre
                        {
                            Description = "Reality"
                        },
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "The RM",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = new Genre
                        {
                            Description = "Comedy"
                        },
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = new Genre
                        {
                            Description = "Adventure"
                        },
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}