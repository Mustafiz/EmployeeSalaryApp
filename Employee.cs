using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Employee
    {
        public string Name { get; set; }
        public double Basic { get; set; }
        public double HouseRent { get; set; }
        public double MedicalAllowance { get; set; }

        public double GetSalary()
        {
            double houseRent = (Basic*HouseRent)/100;
            double medicalAllowance = (Basic*MedicalAllowance)/100;

            return Basic + houseRent + medicalAllowance;
        }
    }
}
