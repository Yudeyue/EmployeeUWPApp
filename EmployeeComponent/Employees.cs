using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent
{
    public class Employees
    {
        public ObservableCollection<EmployeeViewModel> GetEmployees() 
        { 
            var employees = new ObservableCollection<EmployeeViewModel>();
            employees.Add(new EmployeeViewModel
            {
                Id = 1,
                FirstName = "John",
                LastName = "Yu",
                AnnualSalary = 40000,
                Gender = 'm',
                IsManager = false
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Sally",
                LastName = "Yu",
                AnnualSalary = 55000,
                Gender = 'f',
                IsManager = true
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 3,
                FirstName = "Bill",
                LastName = "Yu",
                AnnualSalary = 30000,
                Gender = 'm',
                IsManager = false
            });
            employees.Add(new EmployeeViewModel
            {
                Id = 4,
                FirstName = "Jamie",
                LastName = "Yu",
                AnnualSalary = 80000,
                Gender = 'm',
                IsManager = true
            });
            return employees;
        }
    }
}
