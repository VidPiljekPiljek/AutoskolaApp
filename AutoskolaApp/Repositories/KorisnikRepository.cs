using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.Repositories
{
    public class KorisnikRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public KorisnikRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateKorisnik(Korisnik korisnik)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Korisnici.Add(korisnik);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Korisnik>> GetAllKorisnici()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Korisnik> korisnici = await dbContext.Korisnici.ToListAsync();

                return korisnici;
            }
        }

        public async Task<object> KorisnikAuthentication(string korisnickoIme, string lozinka)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                Korisnik korisnik = await dbContext.Korisnici.FirstOrDefaultAsync(k => k.KorisnickoIme == korisnickoIme && k.Lozinka == lozinka);

                if (korisnik != null) {
                    if (korisnik.IDUloge == 1)
                    {
                        return await dbContext.Administratori.FirstOrDefaultAsync(a => a.IDKorisnika == korisnik.IDKorisnika);
                    }
                    if (korisnik.IDUloge == 2)
                    {
                        return await dbContext.Instruktori.FirstOrDefaultAsync(a => a.IDKorisnika == korisnik.IDKorisnika);
                    }
                    if (korisnik.IDUloge == 3)
                    {
                        return await dbContext.Studenti.FirstOrDefaultAsync(a => a.IDKorisnika == korisnik.IDKorisnika);
                    }
                }
                return null;
            }
        }
    }
}
