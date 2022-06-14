using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

// classes - reference types
public class Employee : IPerson
{
    public Employee()
    {
        Id = 11111;
    }
    public Employee(string firstName, string lastName, int empId = 0)
    {
        FirstName = firstName;
        LastName = lastName;
        EmployeeId = empId;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }

    public int EmployeeId { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly ShiftStartTime { get; set; }
}

public class Manager : Employee, IPerson
{
    public Manager(string firstName, string lastName) : base(firstName, lastName){}
    public void SetReports(int numberOfReports)
    {
        NumberOfDirectReports = numberOfReports;
    }
    public int NumberOfDirectReports { get; private set; }
}

// structs - value types
public struct Age
{
    public Age(DateTime dob, int years)
    {
        BirthDate = dob;
        YearsOld = years;
    }
    public DateTime BirthDate { get; set; }
    public int YearsOld { get; set; }
}

public struct VendorContact : IPerson
{
    public string FirstName { get; set;}
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

// struct cannot inherit from base struct
// public struct BiologicalAge : Age { }

// records - reference types
public record Customer : IPerson
{
    public Customer()
    {}
    public Customer(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

public record PremiereCustomer : Customer
{
    public PremiereCustomer(byte level)
    {
        CustomerLevel = level;
    }
    // CustomerLevel can only set when initialization
    public byte CustomerLevel { get; init; }
}


// record struct - value types
public record struct Order
{
    public int OrderId { get; set; }
    public DateOnly OrderDate { get; set; }
}

