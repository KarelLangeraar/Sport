using Microsoft.EntityFrameworkCore;
using Sport.Interfaces;
using Sport.Models;

namespace Sport.Data
{
    public class SportContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=Data/Sport.db");

        public DbSet<Club> Clubs { get; set; }
        public DbSet<Training> Training { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>()
                .Property<Active>("Active") 
                .HasConversion(x => x.InactiveDate,
                               x => new Active(x));

            modelBuilder.Entity<Team>()
                .Property<Active>("Active")
                .HasConversion(x => x.InactiveDate,
                               x => new Active(x));

            modelBuilder.Entity<Player>()
                .Property<Active>("Active")
                .HasConversion(x => x.InactiveDate,
                               x => new Active(x));

            modelBuilder.Entity<Coach>()
                .Property<Active>("Active")
                .HasConversion(x => x.InactiveDate,
                               x => new Active(x));
        }

    }
}
