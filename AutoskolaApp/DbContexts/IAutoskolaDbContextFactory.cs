﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.DbContexts
{
    public interface IAutoskolaDbContextFactory
    {
        AutoskolaDbContext CreateDbContext();
    }
}
