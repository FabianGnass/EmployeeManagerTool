using EmployeeManagerTool.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagerTool.models
{
    internal class Employee
    {
        private int _id;

        // Formatted identifier exposed as string, e.g. "eNr-1"
        public string Id => $"eNr-{_id}";

        // Numeric id accessors if callers need to read/set the underlying integer
        public int NumericId
        {
            get => _id;
            set => _id = value;
        }

        public Division Division { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string PostalCode { get; set; }
    }
}
