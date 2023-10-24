using System;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _lastName= string.Empty;
        private string _firstname = string.Empty;
        public string LastName 
        {
            get { return _lastName; }
            set
            {
                if (value == _lastName) return;
                _lastName = value;
                NotifyPropertyChanged("LastName");
            }
        }

        public char Gender { get; set; }    

        public bool IsManager { get; set; }

        public decimal AnnualSalary { get; set; }

        public string FirstName
        {
            get { return _firstname; }
            set
            {
                if (_firstname == value) return;
                _firstname = value;
                NotifyPropertyChanged("FirstName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
