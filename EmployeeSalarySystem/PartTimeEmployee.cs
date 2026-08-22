using System;
namespace EmployeeSalarySystem;
class PartTimeEmployee : Employee
{
    decimal HoulryRate ;
    decimal HoursWork;
    public PartTimeEmployee(string name, int employeeId, decimal salary, decimal houlryRate, decimal hoursWork) : base (name, employeeId, salary)
    {
        this.HoulryRate = houlryRate;
        this.HoursWork = hoursWork;

    }
    public override void CalculateSalary()
    {
        decimal totalSalary = HoulryRate * HoursWork;
        Console.WriteLine("Employee Salary:"+totalSalary);
    }
}