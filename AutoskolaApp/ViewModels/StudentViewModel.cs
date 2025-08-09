using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels
{
    public class StudentViewModel
    {
        private readonly Student _student;

        public int IDStudenta => _student.IDStudenta;

        public string OIB => _student.OIB;
        public string Ime => _student.Ime;
        public string Prezime => _student.Prezime;
        public string DatumRodjenja => _student.DatumRodjenja.ToString("d");
        public string DatumPocetka => _student.DatumPocetka.ToString("d");
        public int SatiVoznje => _student.SatiVoznje;
        public int IDKorisnika => _student.IDKorisnika;

        public StudentViewModel(Student student)
        {
            _student = student;
        }

        public StudentViewModel()
        {
        }
    }
}
