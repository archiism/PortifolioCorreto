using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortifolioCorreto.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
         
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Login>()
                .HasData(
                new Data.Login { id = 1, email = "netomelosantana@gmail.com", senha = "2447679Site", usuario = "archiism" });
        }

        public DbSet<Projetos> Projetos { get; set; }
        public DbSet<Logs> Logs { get; set; }
}
}
