// See https://aka.ms/new-console-template for more information
using LinkedIn.Essentials;

Empolyee e = new Empolyee("Matt", "Damon", 5);
Console.WriteLine($"Hello {e.FirstName}! You are a employee. Your Id : {e.EmployeeId}");

Empolyee m = new Manager("Robert", "Criss");
Console.WriteLine($"Hello {m.FirstName}! You are a manager. Your Id : {m.EmployeeId}");
