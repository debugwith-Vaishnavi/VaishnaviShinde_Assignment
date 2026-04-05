//3. Create a class Employee with properties (Id, Name, Salary) and demonstrate encapsulation.
using System;

internal class Employee
{
    // Private fields (data hiding)
    private int id;
    private string name;
    private double salary;

    // Public methods (controlled access)

    public void SetId(int id)
    {
        if (id <= 0)
            Console.WriteLine("Id must be positive.");
        else
            this.id = id;
    }

    public int GetId()
    {
        return id;
    }

    public void SetName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            Console.WriteLine("Name cannot be empty.");
        else
            this.name = name;
    }

    public string GetName()
    {
        return name;
    }

    public void SetSalary(double salary)
    {
        if (salary < 0)
            Console.WriteLine("Salary cannot be negative.");
        else
            this.salary = salary;
    }

    public double GetSalary()
    {
        return salary;
    }
}

internal class EmployeeInfo
{
    static void Main()
    {
        Employee emp = new Employee();

        // ---- Id Input ----
        Console.Write("Enter Employee Id: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            emp.SetId(id);
        }
        else
        {
            Console.WriteLine("Invalid Id input.");
            return;
        }

        // ---- Name Input ----
        Console.Write("Enter Employee Name: ");
        emp.SetName(Console.ReadLine());

        // ---- Salary Input ----
        Console.Write("Enter Salary: ");
        if (double.TryParse(Console.ReadLine(), out double salary))
        {
            emp.SetSalary(salary);
        }
        else
        {
            Console.WriteLine("Invalid Salary input.");
            return;
        }

        // ---- Display Data ----
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"Id: {emp.GetId()}");
        Console.WriteLine($"Name: {emp.GetName()}");
        Console.WriteLine($"Salary: {emp.GetSalary()}");
    }
}