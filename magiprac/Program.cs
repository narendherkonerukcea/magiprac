
// 1) Create Employee Class with Properties (id, firstname, lastname, salary, level).
using System;

class MyClass
{
    public int ID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public decimal Salary { get; set; }
    public int Level { get; set; }
}

class Program
{
    static void Main(string[] args)
    {

        Abc();

    }
    public static void Abc()
    {
        MyClass myObject = new MyClass();
        myObject.ID = 42;
        myObject.FirstName = "koneru";
        myObject.LastName = "Narendher";
        myObject.Salary = 42;
        myObject.Level = 4;
        // Console.WriteLine(myObject.MyProperty);
        Console.WriteLine(myObject.ID);
        Console.WriteLine(myObject.FirstName);
        Console.WriteLine(myObject.LastName);
        Console.WriteLine(myObject.Salary);
        Console.WriteLine(myObject.Level);
    }
}



// 2) Create List of Employee Class(Add few employees manually to that List)

using System;



class Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public string? Department { get; set; }

}

class Program
{
    static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>();



        employees.Add(new Employee { FirstName = "Narendher", LastName = "koneru", Age = 30, Department = "Sales" });
        employees.Add(new Employee { FirstName = "magi", LastName = "kayakokile", Age = 25, Department = "Marketing" });
        employees.Add(new Employee { FirstName = "David", LastName = "koner", Age = 35, Department = "Finance" });


        foreach (Employee employee in employees)
        {
            Console.WriteLine("Name: " + employee.FirstName + employee.LastName);
            Console.WriteLine("Age: " + employee.Age);
            Console.WriteLine("Department: " + employee.Department);
            Console.WriteLine();
        }
    }
}

// 3)Perform search operation on the Employee with FirstName, meaning, If i enter the first name, all his details should come.

using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    // other properties
}

public class Program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { FirstName = "Kneru", LastName = "Narendher", Age = 25 },
            new Employee { FirstName = "Magi", LastName = "kayakokila", Age = 30 },
            // other employees
        };

        Console.Write("Enter first name to search: ");
        string? searchName = Console.ReadLine();

        var searchResults = employees.Where(e => e.FirstName == searchName);

        if (searchResults.Any())
        {
            foreach (var emp in searchResults)
            {
                Console.WriteLine($"Name: {emp.FirstName} {emp.LastName}, Age: {emp.Age}");
            }
        }
        else
        {
            Console.WriteLine("No employee found with the given first name.");
        }
    }
}
