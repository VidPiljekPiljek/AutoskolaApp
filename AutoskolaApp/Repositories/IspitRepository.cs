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
    public class IspitRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public IspitRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task DeleteIspit(int ispitID)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var ispit = dbContext.Ispiti.Find(ispitID);
                if (ispit != null)
                {
                    dbContext.Ispiti.Remove(ispit);
                    dbContext.SaveChanges();
                }
            }
        }

        public async Task<IEnumerable<Ispit>> GetAllIspiti()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Ispit> ispiti = await dbContext.Ispiti.ToListAsync();

                return ispiti;

            }
        }

        public async Task CreateIspit(Ispit ispit)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Ispiti.Add(ispit);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
