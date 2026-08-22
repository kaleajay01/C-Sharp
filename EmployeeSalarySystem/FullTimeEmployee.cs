using System;
namespace EmployeeSalarySystem;
public class FullTimeEmployee : Employee
{
    public FullTimeEmployee(string name, int employeeId, decimal salary) : base(name, employeeId, salary)
    {
    }
    public override void CalculateSalary()
    { 
        decimal bouns = (Salary * 5) / 100;
        decimal totalSalary = Salary + bouns;
        Console.WriteLine("Employee Salary:"+totalSalary);
    }
}