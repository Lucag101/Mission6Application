using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Application.Models
{
    public class MovieApplicationContext: DbContext
    {
        //constructor
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options ) : base (options)
        {
            // keep blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Category> Category { get; set; }

        // Seed the data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Sci-Fi/ Fantasy" },
                new Category { CategoryID = 2, CategoryName = "Children" },
                new Category { CategoryID = 3, CategoryName = "Thriller" },
                new Category { CategoryID = 4, CategoryName = "Horror" },
                new Category { CategoryID = 5, CategoryName = "Action" },
                new Category { CategoryID = 6, CategoryName = "Suspense" },
                new Category { CategoryID = 7, CategoryName = "Comedy" },
                new Category { CategoryID = 8, CategoryName = "Romance" },
                new Category { CategoryID = 9, CategoryName = "Holiday" },
                new Category { CategoryID = 10, CategoryName = "Animated" }

                );
            
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Title = "Harry Potter and the Sorcerer's stone",
                    CategoryId= 1,
                    Year = 2004,
                    Director = "Not sure",
                    Rating= "PG",
                    Edited= true,
                    Lent= "Sarah Mackinley",
                    Notes= "Good Movie. A Little Old"
                },
                new ApplicationResponse
                {
                    ApplicationId = 2,
                    Title = "The Prestige",
                    CategoryId = 6,
                    Year = 2008,
                    Director = "Again,Not sure",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "Kind of sad but good"
                },
                new ApplicationResponse
                {
                    ApplicationId = 3,
                    Title = "Lord Of the Rings",
                    CategoryId = 1,
                    Year = 2006,
                    Director = "I feel like I should know, but I don't",
                    Rating = "PG-13",
                    Edited = true,
                    Lent = "I would never lend this to anybody",
                    Notes = ""
                }
                    );
        }
    }
}
