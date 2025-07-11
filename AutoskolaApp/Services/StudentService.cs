﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;
using AutoskolaApp.Stores;

namespace AutoskolaApp.Services
{
    public class StudentService
    {
        public readonly StudentStore _studentStore;

        public StudentService(StudentStore studentStore)
        {
            _studentStore = studentStore;
        }

        public async Task LoadStudenti()
        {
            await _studentStore.Load();
        }

        public IEnumerable<Student> GetStudenti()
        {
            return _studentStore.Studenti;
        }

        public async Task<IEnumerable<Student>> StudentSearch(string ime, string prezime)
        {
            return await _studentStore.StudentSearch(ime, prezime);
        }

        public async Task<int> GetStudentID(string ime, string prezime)
        {
            return await _studentStore.GetStudentID(ime, prezime);
        }

        public async Task AddStudent(Student student)
        {
            await _studentStore.AddStudent(student);
        }

        public async Task DeleteStudent(int studentID)
        {
            await _studentStore.DeleteStudent(student);
        }
    }
}
