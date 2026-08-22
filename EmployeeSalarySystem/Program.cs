using System;
using System.Runtime.CompilerServices;
using EmployeeSalarySystem;
namespace EmployeeSalarySystem;

class program
{
    static void Main()
    {
        FullTimeEmployee fullTimeEmployee = new FullTimeEmployee("Ajay", 1, 10000);
        FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee("Ak", 2, 10600);
        PartTimeEmployee partTimeEmployee = new PartTimeEmployee("K", 3, 11000, 150, 9);
        PartTimeEmployee partTimeEmployee1 = new PartTimeEmployee("KK", 4, 11700, 150, 7);

        // partTimeEmployee.CalculateSalary();
        fullTimeEmployee.DisplayEmployeeDetails();
        fullTimeEmployee.CalculateSalary();
        Console.WriteLine("");
        fullTimeEmployee1.DisplayEmployeeDetails();
        fullTimeEmployee1.CalculateSalary();
        Console.WriteLine("");
        partTimeEmployee.DisplayEmployeeDetails();
        partTimeEmployee.CalculateSalary();
        Console.WriteLine("");
        partTimeEmployee1.DisplayEmployeeDetails();
        partTimeEmployee1.CalculateSalary();

    }
}
