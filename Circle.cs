using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryApp
{
    class Circle
    {
        private const double PI = 3.1416;

        //public double Radius { get; set; }

        public double GetDiameter(double radius)
        {
            return radius*radius;
        }

        public double Perimeter(double radius)
        {
            return 2*PI*radius;
        }

        public double Area(double radius)
        {
            return PI*radius*radius;
        }
    }
}
