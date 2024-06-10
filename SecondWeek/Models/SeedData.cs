using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SecondWeek.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecondWeek.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SecondWeekContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SecondWeekContext>>()))
            {
                // Look for any movies
                if (context.Movies.Any())
                {
                    return; // DB has been seeded
                }
                context.Movies.AddRange(
                    new Movies
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romtantic Comedy",
                        Rating = "a",
                        Price = 7.99M
                    },
                    new Movies
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Rating = "f",
                        Price = 8.99M
                    },
                    new Movies
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Rating = "R",
                        Price = 9.99M
                    },
                    new Movies
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Rating = "R",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
