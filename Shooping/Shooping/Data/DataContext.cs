using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shooping.Data.Entities;

namespace Shooping.Data
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasIndex(c => c.Name).IsUnique();
            builder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
            builder.Entity<State>().HasIndex("Name","CountryId").IsUnique();
            builder.Entity<City>().HasIndex("Name", "StateId").IsUnique();
        }
    }
}
