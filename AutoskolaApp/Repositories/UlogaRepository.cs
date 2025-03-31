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
    public class UlogaRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public UlogaRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<Uloga>> GetAllUloge()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Uloga> uloge = await dbContext.Uloge.ToListAsync();

                return uloge;
            }
        }
    }
}
