using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connectionString).Options;

            return new AutoskolaDbContext(options);
        }
    }
}
