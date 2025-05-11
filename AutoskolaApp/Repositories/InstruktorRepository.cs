using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using AutoskolaApp.DbContexts;
using AutoskolaApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.Repositories
{
    public class InstruktorRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public InstruktorRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateInstruktor(Instruktor instruktor)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Instruktori.Add(instruktor);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Instruktor>> GetAllInstruktori()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Instruktor> instruktori = await dbContext.Instruktori.ToListAsync();

                return instruktori;
            }
        }

        public async Task<Guid> GetInstruktorID(string ime, string prezime)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                try
                {
                    return await dbContext.Instruktori.Where(i => i.Ime == ime && i.Prezime == prezime).Select(i => i.IDInstruktora).FirstOrDefaultAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return Guid.Empty;
                }
            }
        }
    }
}
