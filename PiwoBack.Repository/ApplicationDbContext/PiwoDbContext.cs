using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PiwoBack.Data.Models;

namespace PiwoBack.Repository.ApplicationDbContext
{
    public class PiwoDbContext : DbContext
    {
        public DbSet<Beer> Beers { get; set; }
        public DbSet<Brewery> Breweries { get; set; }
        public DbSet<BrewingGroup> BrewingGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<BeerRate> BeerRates { get; set; }

        public PiwoDbContext(DbContextOptions<PiwoDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BrewingGroup>().HasMany(b => b.Breweries).WithOne(bg => bg.BrewingGroup);
            modelBuilder.Entity<Brewery>().HasMany(b => b.Beers).WithOne(b => b.Brewery);
            modelBuilder.Entity<Beer>().HasMany(c => c.Comments).WithOne(b => b.Beer);
            modelBuilder.Entity<Beer>().HasMany(b => b.BeerRates).WithOne(b => b.Beer);


            modelBuilder.Entity<UserRole>().HasMany(u => u.Users).WithOne(r => r.Role);
        }
    }
}
