using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MVCMovieContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met Sally",
                        ReleaseDate = DateTime.Parse("1989-01-01"),
                        Genre = "Romantic Comedy",
                        Rating = "R",
                        Price = 7
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1994-01-01"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 10
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1996-01-01"),
                        Genre = " Comedy",
                        Rating = "R",
                        Price = 12
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1999-01-01"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 6
                    }
                );
                context.SaveChanges();
            }
        }
    }
}