using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RelationsNaN.Models;

namespace RelationsNaN.Data
{
    public class RelationsNaNContext : DbContext
    {
        public RelationsNaNContext (DbContextOptions<RelationsNaNContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        public DbSet<Game> Game { get; set; } = default!;
        public DbSet<Genre> Genre { get; set; } = default!;
        public DbSet<Platform> Platform { get; set; } = default!;
    }
}
