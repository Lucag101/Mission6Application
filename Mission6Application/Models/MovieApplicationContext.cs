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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    ApplicationId = 1,
                    Title = "Harry Potter and the Sorcerer's stone",
                    Category= "Fantasy",
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
                    Category = "Thriller",
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
                    Category = "Fantasy",
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
