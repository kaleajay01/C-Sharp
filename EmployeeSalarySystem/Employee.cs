namespace EmployeeSalarySystem;
public abstract class Employee
{
    public string Name {get;set;}
    public int EmployeeId {get;set;}
    protected decimal Salary {get;set;}

    public Employee()
    {
        EmployeeId = 1;
        Name = "Ajay";
        Salary = 10000;
    }
    public Employee(string name, int employeeId, decimal salary)
    {
        this.EmployeeId = employeeId;
        this.Name = name;
        this.Salary = salary;
    }
    public abstract void CalculateSalary();

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Id:"+EmployeeId);
        Console.WriteLine("Name:"+Name);
        Console.WriteLine("Age:"+Salary);
    }
}