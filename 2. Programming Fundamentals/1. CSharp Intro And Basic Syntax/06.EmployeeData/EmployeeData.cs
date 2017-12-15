using System;


class EmployeeData
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int employeeID = int.Parse(Console.ReadLine());
        double salary = double.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Employee ID: {0:D8}", employeeID);
        Console.WriteLine("Salary: {0:f2}", salary);
    }   
}

