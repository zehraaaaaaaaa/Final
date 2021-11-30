using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface Employee
    {
        HourlyEmployee HourlyEmployee { get; set; }
        SalaryEmployee SalaryEmployee { get; set; }

        void CalculateSalary();
       
        
       
    }
}