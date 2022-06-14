﻿using System;
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
public class Empolyee : IPerson
{
    public Employee()
    {

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
    public int NumberOfDirectReports { get; set; }
}

// structs - value types
public struct Age
{
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
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }
    public Age Age { get; set; }
}

public record PremiereCustomer : Customer
{
    public byte CustomerLevel { get; init; }
}


// record struct - value types
public record struct Order
{
    public int OrderId { get; set; }
    public DateOnly OrderDate { get; set; }
}

