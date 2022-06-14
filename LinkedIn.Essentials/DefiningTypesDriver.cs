using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials
{
    public static class DefiningTypesDriver
    {
        public static void Drive()
        {
            Console.WriteLine("=========== Defining Types ===========");
            // Custom constuctor is called.
            Employee e = new Employee("Matt", "Damon", 5);
            Console.WriteLine($"Hello {e.FirstName}! You are an employee.Your Id: {e.Id}. Your EmployeeId : {e.EmployeeId}");

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
                Age = new Age { BirthDate = new DateOnly(2002, 05, 05), YearsOld = 25 },
            };
            Console.WriteLine($"Hello {e2.FirstName} {e2.LastName}! You are an employee. Your Id: {e2.Id}. Your EmployeeId: {e2.EmployeeId}. Your Start Date: {e2.StartDate}. Birthdate: {e2.Age.BirthDate}. Age: {e2.Age.YearsOld}");

            // Custom constructor is called.
            Employee e3 = new Employee("Robin", "Hood", 300)
            {
                StartDate = new DateOnly(1999, 01, 25),
            };
            Console.WriteLine($"Hello {e3.FirstName} {e3.LastName}! You are an employee. Your Id: {e3.Id}. Your EmployeeId: {e3.EmployeeId}. Your Start Date: {e3.StartDate}");

            PremiereCustomer pcust = new PremiereCustomer(2);
            pcust.FirstName = "Bob";
            Console.WriteLine($"Hi, {pcust.FirstName}. You are a premier customer. Your Level: {pcust.CustomerLevel}");

            Manager m2 = new Manager("Manager", "Boss");
            m2.SetReports(9);
            Console.WriteLine($"{m2.FirstName} {m2.LastName}. No of Reports: {m2.NumberOfDirectReports}");
        }
    }
}
