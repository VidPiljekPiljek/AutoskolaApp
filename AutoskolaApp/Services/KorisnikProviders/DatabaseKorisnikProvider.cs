﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.Services.KorisnikProviders
{
    public class DatabaseKorisnikProvider : IKorisnikProvider
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public DatabaseKorisnikProvider(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
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
