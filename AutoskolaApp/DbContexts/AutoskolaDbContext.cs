using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.DbContexts
{
    public class AutoskolaDbContext : DbContext
    {
        public AutoskolaDbContext(DbContextOptions options) : base(options) {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Uloga>().HasData(
                new Uloga(Guid.NewGuid(), "Administrator", null),
                new Uloga(Guid.NewGuid(), "Instruktor", null),
                new Uloga(Guid.NewGuid(), "Student", null)
            );
        }

        public DbSet<Administrator> Administratori { get; set; }
        public DbSet<Instruktor> Instruktori { get; set; }
        public DbSet<Ispit> Ispiti { get; set; }
        public DbSet<Korisnik> Korisnici { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Vozilo> Vozila { get; set; }
        public DbSet<Voznja> Voznje { get; set; }
        public DbSet<Uplata> Uplate { get; set; }
        public DbSet<Uloga> Uloge { get; set; }
        public DbSet<PolaznikIspita> PolazniciIspita { get; set; }
    }
}
