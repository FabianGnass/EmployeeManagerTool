using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagerTool.models;
using EmployeeManagerTool.mvvm;

namespace EmployeeManagerTool.viewModel
{
    internal class EmployeeListViewModel : ViewModelFoundation
    {
        public ObservableCollection<Employee> Employees { get; set;}
        public EmployeeListViewModel()
        {
            Employees = new ObservableCollection<Employee>();
            Employees.Add(new Employee
            {
                NumericId = 1,
                Name = "John",
                Surname = "Doe",
                Division = enums.Division.IT,
                DateOfBirth = new DateTime(1990, 1, 1),
                Salary = 60000,
                Email = "john.doe@gmx.net"
            });
        }
        private Employee _selectedEmployee;
        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }
    }
}
