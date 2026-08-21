using System;
using System.Runtime.CompilerServices;
using EmployeeSalarySystem;
namespace EmployeeSalarySystem;


class program
{
    static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
        
        fullTimeEmployee.CalculateSalary();
        partTimeEmployee.CalculateSalary();
    }
}
