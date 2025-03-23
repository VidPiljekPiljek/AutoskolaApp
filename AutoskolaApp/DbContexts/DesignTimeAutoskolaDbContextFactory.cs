using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace AutoskolaApp.DbContexts
{
    public class DesignTimeAutoskolaDbContextFactory : IDesignTimeDbContextFactory<AutoskolaDbContext>
    {
        public AutoskolaDbContext CreateDbContext(string[] args)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data source=autoskola.db").Options;

            return new AutoskolaDbContext(options);
        }
    }
}
