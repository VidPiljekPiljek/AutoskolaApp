using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.DTOs;
using AutoskolaApp.Models;

namespace AutoskolaApp.Services.KorisnikCreators
{
    public class DatabaseKorisnikCreator : IKorisnikCreator
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public DatabaseKorisnikCreator(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateKorisnik(Korisnik korisnik)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                KorisnikDTO korisnikDTO = MapToDTO(korisnik);

                dbContext.Korisnici.Add(korisnik);
                await dbContext.SaveChangesAsync();
            }
        }

        private KorisnikDTO MapToDTO(Korisnik korisnik)
        {
            return new KorisnikDTO()
            {
                IDKorisnika = korisnik.IDKorisnika,
                KorisnickoIme = korisnik.KorisnickoIme,
                Lozinka = korisnik.Lozinka,
                IDUloge = korisnik.IDUloge
            };
        }
    }
}
