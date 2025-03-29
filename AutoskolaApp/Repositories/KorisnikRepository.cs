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
    }
}
