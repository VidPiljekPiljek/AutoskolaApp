﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;
using AutoskolaApp.Models;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AutoskolaApp.Repositories
{
    public class UplataRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public UplataRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateUplata(Uplata uplata)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Uplate.Add(uplata);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteUplata(int uplataID)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var uplata = dbContext.Uplate.Find(uplataID);
                if (uplata != null)
                {
                    dbContext.Uplate.Remove(uplata);
                    dbContext.SaveChanges();
                }
                //dbContext.Instruktori.Remove(instruktor);
                //await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Uplata>> GetAllUplate()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Uplata> uplate = await dbContext.Uplate.ToListAsync();

                return uplate;

            }
        }
    }
}
