using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.DbContexts
{
    public class AutoskolaDbContextFactory : IAutoskolaDbContextFactory
    {
        private readonly string _connectionString;

        public AutoskolaDbContextFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public AutoskolaDbContext CreateDbContext()
        {
            throw new NotImplementedException();
        }
    }
}
