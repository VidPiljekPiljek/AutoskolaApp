using AutoskolaApp.Models;
using AutoskolaApp.Services;
using AutoskolaApp.ViewModels.FormViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoskolaApp.Commands.SearchCommands
{
    internal class InstruktorStudentSearchCommand : AsyncCommandBase
    {
        private readonly VoznjeFormViewModel _formViewModel;
        private readonly StudentService _studentService;
        private readonly InstruktorService _instruktorService;

        public InstruktorStudentSearchCommand(VoznjeFormViewModel formViewModel, StudentService studentService, InstruktorService instruktorService)
        {
            _formViewModel = formViewModel;
            _studentService = studentService;
            _instruktorService = instruktorService;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            try
            {
                IEnumerable<Student> studenti = await _studentService.StudentSearch(_formViewModel.StudentIme, _formViewModel.StudentPrezime);
                IEnumerable<Instruktor> instruktori = await _instruktorService.InstruktorSearch(_formViewModel.InstruktorIme, _formViewModel.InstruktorPrezime);

                _formViewModel.StudentFound(studenti);
                _formViewModel.InstruktorFound(instruktori);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
