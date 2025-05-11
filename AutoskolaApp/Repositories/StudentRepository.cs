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
    public class StudentRepository
    {
        private readonly IAutoskolaDbContextFactory _dbContextFactory;

        public StudentRepository(IAutoskolaDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task CreateStudent(Student student)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {

                dbContext.Studenti.Add(student);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Student>> GetAllStudenti()
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                IEnumerable<Student> studenti = await dbContext.Studenti.ToListAsync();

                return studenti;

            }
        }
    }
}
