using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Repositories;

namespace AutoskolaApp.Stores
{
    public class StudentStore
    {
        private readonly List<Student> _studenti;
        public IEnumerable<Student> Studenti => _studenti;
        private readonly StudentRepository _studentRepository;
        private Lazy<Task> _initializeLazy;

        public event Action<Student> StudentCreated;
        public event Action<Student> StudentDeleted;

        public StudentStore(StudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            _initializeLazy = new Lazy<Task>(Initialize);

            _studenti = new List<Student>();
        }

        public async Task<IEnumerable<Student>> StudentSearch(string ime, string prezime)
        {
            return await _studentRepository.StudentSearch(ime, prezime);
        }

        public async Task Load()
        {
            try
            {
                await _initializeLazy.Value;
            }
            catch (Exception)
            {
                _initializeLazy = new Lazy<Task>(Initialize); // Pokusaj ponovo
                throw;
            }
        }

        private void OnStudentCreated(Student instruktor)
        {
            StudentCreated?.Invoke(instruktor);
        }

        private void OnStudentDeleted(Student instruktor)
        {
            StudentDeleted?.Invoke(instruktor);
        }

        public async Task AddStudent(Student student)
        {
            await _studentRepository.CreateStudent(student);

            _studenti.Add(student);

            OnStudentCreated(student);
        }

        public async Task DeleteStudent(int studentID)
        {
            await _studentRepository.DeleteStudent(studentID);

            Student student = _studenti.FirstOrDefault(student => student.IDStudenta == studentID);

            _studenti.RemoveAll(student => student.IDStudenta == studentID);

            OnStudentDeleted(student);
        }

        public async Task<int> GetStudentID(string ime, string prezime)
        {
            return await _studentRepository.GetStudentID(ime, prezime);
        }
        private async Task Initialize()
        {
            IEnumerable<Student> studenti = await _studentRepository.GetAllStudenti();

            _studenti.Clear();
            _studenti.AddRange(studenti);
        }
    }
}
