using System;
namespace EmployeeSalarySystem;

class PartTimeEmployee : Employee
{
    decimal houlryRate = 90;
    decimal hoursWork = 5;
    public override void CalculateSalary()
    {
        decimal totalSalary = houlryRate * hoursWork;
        Console.WriteLine(totalSalary);
    }
}