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

        public async Task UpdateStudent(Student student)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var studentTemp = dbContext.Studenti.Find(student.IDStudenta);
                if (studentTemp != null)
                {
                    dbContext.Entry(studentTemp).CurrentValues.SetValues(student);
                    await dbContext.SaveChangesAsync();
                }
                //dbContext.Instruktori.Add(instruktor);
                //await dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteStudent(int studentID)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                var student = dbContext.Studenti.Find(studentID);
                if (student != null)
                {
                    dbContext.Studenti.Remove(student);
                    dbContext.SaveChanges();
                }
                //dbContext.Instruktori.Remove(instruktor);
                //await dbContext.SaveChangesAsync();
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

        public async Task<IEnumerable<Student>> StudentSearch(string ime, string prezime)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                try
                {
                    return await dbContext.Studenti.Where(s => s.Ime == ime && s.Prezime == prezime).ToListAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return null;
            }
        }

        public async Task<int> GetStudentID(string ime, string prezime)
        {
            using (AutoskolaDbContext dbContext = _dbContextFactory.CreateDbContext())
            {
                try
                {
                    return await dbContext.Studenti.Where(s => s.Ime == ime && s.Prezime == prezime).Select(s => s.IDStudenta).FirstOrDefaultAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return -1;
                }
            }
        }
    }
}
