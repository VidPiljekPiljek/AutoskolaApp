using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace AutoskolaApp.DbContexts
{
    public class InMemoryAutoskolaDbContextFactory : IAutoskolaDbContextFactory
    {
        private readonly SqliteConnection _connection;

        public InMemoryAutoskolaDbContextFactory()
        {
            _connection = new SqliteConnection("Data source=:memory:");
            _connection.Open();
        }

        public AutoskolaDbContext CreateDbContext()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(_connection).Options;

            return new AutoskolaDbContext(options);
        }
    }
}
