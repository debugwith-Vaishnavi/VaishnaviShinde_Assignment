//4. Write a LINQ query to filter employees with salary > 50,000.

using System.Collections.Generic;
using System.Linq;

public class Emp
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public double Salary { get; set; }

}
internal class LINQFilter
{
    public static void Main()
    {
        List<Emp> employees = new List<Emp>();

        Console.Write("Enter number of employees: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Emp emp = new Emp();

            Console.WriteLine($"\nEnter details for Employee {i + 1}:");

            Console.Write("Enter Id: ");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            emp.Name = Console.ReadLine();

            Console.Write("Enter Salary: ");
            emp.Salary = Convert.ToDouble(Console.ReadLine());

            employees.Add(emp);
        }

        // Filter condition
        var result = employees.Where(e => e.Salary > 50000);

        Console.WriteLine("\nEmployees with Salary > 50000:");

        foreach (var emp in result)
        {
            Console.WriteLine($"{emp.Name} - {emp.Salary}");
        }
    }
}

