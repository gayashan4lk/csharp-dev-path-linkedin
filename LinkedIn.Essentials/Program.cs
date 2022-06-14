// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

// Custom constuctor is called.
Employee e = new Employee("Matt", "Damon", 5);
Console.WriteLine($"Hello {e.FirstName}! You are a employee.Your Id: {e.Id}. Your EmployeeId : {e.EmployeeId}");

// Custom constuctor is called.
Employee m = new Manager("Robert", "Criss");
Console.WriteLine($"Hello {m.FirstName}! You are a manager.Your Id: {m.Id}. Your EmployeeId : {m.EmployeeId}");

// Default constructor is called.
Employee e2 = new Employee
{
    FirstName = "Santa",
    LastName = "Clause",
    EmployeeId = 251,
    StartDate = new DateOnly(2022, 6, 05),
};
Console.WriteLine($"Hello {e2.FirstName} {e2.LastName}! You are a employee. Your Id: {e2.Id}. Your EmployeeId: {e2.EmployeeId}. Your Start Date: {e2.StartDate}");

// Custom constructor is called.
Employee e3 = new Employee("Robin", "Hood", 300)
{
    StartDate = new DateOnly(1999, 01, 25),
};
Console.WriteLine($"Hello {e3.FirstName} {e3.LastName}! You are a employee. Your Id: {e3.Id}. Your EmployeeId: {e3.EmployeeId}. Your Start Date: {e3.StartDate}");
