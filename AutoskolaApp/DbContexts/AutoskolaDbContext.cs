using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

            modelBuilder.Entity<Uloga>()
                .HasMany(e => e.Korisnici)
                .WithOne(e => e.Uloga)
                .HasForeignKey(e => e.IDUloge)
                .IsRequired();

            modelBuilder.Entity<Korisnik>()
                .HasOne(e => e.Administrator)
                .WithOne(e => e.Korisnik)
                .HasForeignKey<Administrator>(e => e.IDKorisnika)
                .IsRequired();
            modelBuilder.Entity<Korisnik>()
                .HasOne(e => e.Instruktor)
                .WithOne(e => e.Korisnik)
                .HasForeignKey<Instruktor>(e => e.IDKorisnika)
                .IsRequired();
            modelBuilder.Entity<Korisnik>()
                .HasOne(e => e.Student)
                .WithOne(e => e.Korisnik)
                .HasForeignKey<Student>(e => e.IDKorisnika)
                .IsRequired();

            modelBuilder.Entity<Ispit>()
                .HasMany(e => e.PolazniciIspita)
                .WithOne(e => e.Ispit)
                .HasForeignKey(e => e.IDIspita)
                .IsRequired();

            modelBuilder.Entity<Instruktor>()
                .HasMany(e => e.Ispiti)
                .WithOne(e => e.Instruktor)
                .HasForeignKey(e => e.IDIspita)
                .IsRequired();
            modelBuilder.Entity<Instruktor>()
                .HasMany(e => e.Voznje)
                .WithOne(e => e.Instruktor)
                .HasForeignKey(e => e.IDVoznje)
                .IsRequired();
            modelBuilder.Entity<Instruktor>()
                .HasOne(e => e.Vozilo)
                .WithOne(e => e.Instruktor)
                .HasForeignKey<Vozilo>(e => e.IDInstruktora)
                .IsRequired();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.PolazniciIspita)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.IDStudenta)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Voznje)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.IDVoznje)
                .IsRequired();
            modelBuilder.Entity<Student>()
                .HasMany(e => e.Uplate)
                .WithOne(e => e.Student)
                .HasForeignKey(e => e.IDStudenta)
                .IsRequired();
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
