using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using AutoskolaApp.Stores;
using AutoskolaApp.ViewModels;

namespace AutoskolaApp.Converters
{
    public class KorisnikUlogaToNavigationItemsConverter : IValueConverter
    {
        public DashboardViewModel DashboardViewModel { get; set; }
        public KorisnikStore KorisnikStore { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
                    return DashboardViewModel.AdminNavigationItems;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
