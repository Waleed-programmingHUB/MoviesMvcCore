using Microsoft.EntityFrameworkCore;
using MoviesMvcCore.Models;

namespace MoviesMvcCore.Data
{
    public class SeedData
    {
        public static void Initializer(IServiceProvider serviceProvider)
        {
            using (var context = new MoviesMvcCoreContext(
                serviceProvider.GetRequiredService<DbContextOptions<MoviesMvcCoreContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }


                context.Movie.AddRange(
                    new Movie
                    {
                        MovieTitle = "The Legend of Maula Jatt",
                        MovieUrl = "https://www.youtube.com/watch?v=pEWqOAcYgpQ", // replace with actual URL
                        Genre = "Action",
                        DateOfRelease = DateTime.Parse("2024-01-01"),
                        Price = 12.99M,
                        Rating = "PG-13",
                        createAt = DateTime.Parse("2024-01-10")
                    },

                    new Movie
                    {
                        MovieTitle = "Punjab Nahi Jaunga",
                        MovieUrl = "https://www.youtube.com/watch?v=RV0MtaqlhZ4", 
                        Genre = "Romantic Comedy",
                        DateOfRelease = DateTime.Parse("2024-02-15"),
                        Price = 14.99M,
                        Rating = "PG",
                        createAt = DateTime.Parse("2024-02-20")
                    },

                    new Movie
                    {
                        MovieTitle = "Quaid-e-Azam Zindabad",
                        MovieUrl = "https://www.youtube.com/watch?v=ti1Vy1LQhAM", 
                        Genre = "Action/Comedy",
                        DateOfRelease = DateTime.Parse("2024-03-10"),
                        Price = 16.99M,
                        Rating = "PG-13",
                        createAt = DateTime.Parse("2024-03-15")
                    },

                    new Movie
                    {
                        MovieTitle = "Joyland",
                        MovieUrl = "https://www.youtube.com/watch?v=gy9bNgbZMJI", 
                        Genre = "Drama",
                        DateOfRelease = DateTime.Parse("2024-04-05"),
                        Price = 10.99M,
                        Rating = "R",
                        createAt = DateTime.Parse("2024-04-10")
                    },

                    new Movie
                    {
                        MovieTitle = "Kamli",
                        MovieUrl = "https://www.youtube.com/watch?v=C8kSrkz8Hz8", 
                        Genre = "Song",
                        DateOfRelease = DateTime.Parse("2024-05-01"),
                        Price = 13.99M,
                        Rating = "PG",
                        createAt = DateTime.Parse("2024-05-05")
                    },

                    new Movie
                    {
                        MovieTitle = "Terminator 2",
                        MovieUrl = "https://www.youtube.com/watch?v=EW6qWtznYt4&t=2100s", 
                        Genre = "Action",
                        DateOfRelease = DateTime.Parse("1991-07-03"),
                        Price = 13.99M,
                        Rating = "PG",
                        createAt = DateTime.Parse("2024-05-05")
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
