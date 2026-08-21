using System;
namespace EmployeeSalarySystem;


public class FullTimeEmployee : Employee
{

    public override void CalculateSalary()
    {
        decimal basicSalary = 15000;
        
        decimal bouns = (basicSalary * 5) / 100;
        decimal totalSalary = basicSalary + bouns;
        Console.WriteLine(totalSalary);
    }
}