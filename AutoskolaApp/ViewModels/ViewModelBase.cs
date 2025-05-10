using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoskolaApp.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        private bool _isLoaded;
        public bool IsLoaded
        {
            get { return _isLoaded; }
            set { _isLoaded = value; OnPropertyChanged(nameof(IsLoaded)); }
        }

        public virtual ViewModelBase LoadViewModel()
        {
            return new ViewModelBase();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Dispose() { }
    }
}
