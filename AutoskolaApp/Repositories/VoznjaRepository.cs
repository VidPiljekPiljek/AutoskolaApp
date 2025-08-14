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
    public class VoznjaRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public VoznjaRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateVoznja(Voznja voznja)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Voznje.Add(voznja);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateVoznja(Voznja voznja)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var voznjaTemp = dbContext.Voznje.Find(voznja.IDVoznje);
                if (voznjaTemp != null)
                {
                    dbContext.Entry(voznjaTemp).CurrentValues.SetValues(voznja);
                    await dbContext.SaveChangesAsync();
                }
                //dbContext.Instruktori.Add(instruktor);
                //await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteVoznja(int voznjaID)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var voznja = dbContext.Voznje.Find(voznjaID);
                if (voznja != null)
                {
                    dbContext.Voznje.Remove(voznja);
                    dbContext.SaveChanges();
                }
            }
        }

        public async Task<IEnumerable<Voznja>> GetAllVoznje()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Voznja> voznje = await dbContext.Voznje.ToListAsync();

                return voznje;

            }
        }
    }
}
