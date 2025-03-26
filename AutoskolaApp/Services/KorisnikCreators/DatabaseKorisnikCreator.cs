using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
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

            }
        }
    }
}
