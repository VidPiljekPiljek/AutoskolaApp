using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoskolaApp.Models;

namespace AutoskolaApp.ViewModels
{
    public class IspitViewModel
    {
        private readonly Ispit _ispit;

        public int IDIspita => _ispit.IDIspita;

        public DateTime DateTime => _ispit.DateTime;
        public string VrstaIspita => _ispit.VrstaIspita;
        public int IDInstruktora => _ispit.IDInstruktora;

        public IspitViewModel(Ispit ispit) => _ispit = ispit;

        public IspitViewModel()
        {
        }
    }
}
