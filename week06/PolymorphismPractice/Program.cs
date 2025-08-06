using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Polymorphism Practice from Demo.");

        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetName("John");
        hEmployee.SetIdNumber("123abc");
        hEmployee.SetPayRate(15);
        hEmployee.SetHours(35);

        SalarayEmployee sEmployee = new SalarayEmployee();
        sEmployee.SetName("Peter");
        sEmployee.SetIdNumber("456def");
        sEmployee.salary(60000);

        // DisplayEmployeeInformation(hEmployee);
        // DisplayEmployeeInformation(sEmployee);

        List<Employee> employees = new List<Employee>();
        employees.Add(hEmployee);
        employees.Add(sEmployee);

        foreach (Employee employee in employees)
        {
            DisplayEmployeeInformation(employee);
        }
    }

    public static void DisplayEmployeeInformation(Employee employee)
    {
        Console.WriteLine($"{employee.GetName()}");

        float pay = employee.GetPay();
        Console.WriteLine($"Pay: ${pay}");
    }
}