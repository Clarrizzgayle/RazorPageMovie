using Microsoft.EntityFrameworkCore;
using RazorPageMovie.Data;

namespace RazorPageMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)

        {
            using (var context = new RazorPageMovieContext(serviceProvider.GetRequiredService<
                DbContextOptions<RazorPageMovieContext>>()))
            {
                if (context == null || context.movie == null)
                {
                    throw new ArgumentNullException("null RazorPageMovieContext");
                }
                if (context.movie.Any())
                {
                    return;
                }
                context.movie.AddRange(
                    new movie
                    {
                        Title = "Doremon",
                        DateRelease = DateTime.Parse("1996-4-03"),
                        Genre = "Kids",
                        Price = 4.99M

                    },
                    new movie
                    {
                        Title = "Power Ranger",
                        DateRelease = DateTime.Parse("1996-10-09"),
                        Genre = "Kids",
                        Price = 10.9M

                    },
                    new movie
                    {
                        Title = "Shaman King",
                        DateRelease = DateTime.Parse("1996-8-03"),
                        Genre = "anime",
                        Price = 54M

                    }
                    );
                context.SaveChanges();

            }

        }
    }
}
