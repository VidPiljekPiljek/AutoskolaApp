using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AutoskolaApp.ViewModels;
using AutoskolaApp.ViewModels.PageViewModels.Administrator;
using Wpf.Ui.Abstractions.Controls;

namespace AutoskolaApp.Views.Pages.Administrator
{
    /// <summary>
    /// Interaction logic for InstruktoriPage.xaml
    /// </summary>
    public partial class InstruktoriPage : Page, INavigableView<InstruktoriPageViewModel>
    {
        public InstruktoriPageViewModel ViewModel { get; }

        public InstruktoriPage(InstruktoriPageViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }

        public InstruktoriPage()
        {
            InitializeComponent();
        }
    }
}
