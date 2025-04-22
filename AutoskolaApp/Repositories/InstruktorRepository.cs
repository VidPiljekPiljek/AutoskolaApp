using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.DbContexts;

namespace AutoskolaApp.Repositories
{
    public class InstruktorRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public InstruktorRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
    }
}
