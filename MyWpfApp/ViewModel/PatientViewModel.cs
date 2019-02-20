using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWpfApp.ViewModel
{
    internal class PatientViewModel : INotifyPropertyChanged
    {





        public event PropertyChangedEventHandler PropertyChanged;

        public void HandleOnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
