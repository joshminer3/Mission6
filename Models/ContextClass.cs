using System;
using Microsoft.EntityFrameworkCore;
namespace Mission6.Models
{
	public class ContextClass : DbContext
	{
		//Constructor
		public ContextClass (DbContextOptions<ContextClass> options) : base (options)
		{
			//Leave Blank for now
		}

		public DbSet<MovieForm> Responses { get; set; }


		protected override void OnModelCreating(ModelBuilder mb)
		{
            mb.Entity<MovieForm>().HasData(

                new MovieForm
                {
                    AppId = 1,
                    Category = "Musical",
                    Title = "School of Rock",
                    Year = 2003,
                    Director = "Richard Linklatler",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Great Movie"
                },

                new MovieForm
                {
                    AppId = 2,
                    Category = "Fantasy",
                    Title = "Lord of the Rings",
                    Year = 2001,
                    Director = "Peter Jackson",
                    Rating = "PG-13",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Fantastic Movie"
                },


                new MovieForm
                {
                    AppId = 3,
                    Category = "Drama",
                    Title = "Whiplash",
                    Year = 2014,
                    Director = "Damien Chazelle",
                    Rating = "R",
                    Edited = true,
                    LentTo = "Josh",
                    Notes = "Amazing Film"
                }
            );
		}

	}
}

