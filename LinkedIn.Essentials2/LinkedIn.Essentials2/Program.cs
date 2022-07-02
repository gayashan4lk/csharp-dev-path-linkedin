using Essentials2.Generics;
using System.Text.Json;

var customer1 = new Customer
{
    Id = 8,
    FirstName = "Incredible",
    LastName = "Hulk",
    CreatedDate = DateTime.Now,
};

var customer2 = new Customer
{
    Id = 5,
    FirstName = "Spider",
    LastName = "Man",
    CreatedDate = DateTime.Now,
};

CustomerToPersonMapper mapper = new CustomerToPersonMapper();
var person = mapper.Map(customer1);

Console.WriteLine($"Customer Id: {customer1.Id} \nCustomer Name: {customer1.FirstName} {customer1.LastName} \nCustomer CreateDate: {customer1.CreatedDate} \n");
Console.WriteLine("[Customer] -> [Person]\n");
Console.WriteLine($"Person Id: {person.Id} \nPerson Name: {person.FirstName} {person.LastName} \nPerson Age: {person.Age}\n");

var person2 = customer1.Map<Person>(mapper);
Console.WriteLine($"Person Id: {person2.Id} \nPerson Name: {person2.FirstName} {person.LastName} \nPerson Age: {person2.Age}\n");

var sorter = new Sorter<Customer>();
var customers = new Customer[] { customer1, customer2 };
sorter.Sort(customers);
foreach (var customer in customers)
{
    Console.WriteLine($"{customer.Id}: {customer.FirstName} {customer.LastName}");
}



/*
string jsonPerson = @"{""Id"":0, ""FirstName"": ""Balck"", ""LastName"":""Widow"", ""Age"":50}";

var jperson = JsonSerializer.Deserialize<Person>(jsonPerson);

Console.WriteLine($"Json Person: {jperson?.FirstName} {jperson?.LastName}");

// Generic types, Both of these are the same.
int? p = 7;
Nullable<int> q = 1;

Nullable<DateTime> myDateTime = null;
Console.WriteLine("DateTime (HasValue): " + myDateTime.HasValue);
Console.WriteLine("DateTime (ToString): " + myDateTime.ToString());
Console.WriteLine("DateTime (GetValueOrDefault): " + myDateTime.GetValueOrDefault());

var p1 = new Person
{
    FirstName = "Matt",
    LastName = "Damon",
    Age = 45,
};

var p2 = new Person
{
    FirstName = "Robert",
    LastName = "Downey",
    Age = 25
};

Swap<Person>(ref p1, ref p2);

Console.WriteLine($"Person 1: {p1.FirstName} {p1.LastName} and Person 2: {p2.FirstName} {p2.LastName}");

int x = 3, y = 8;

Swap<int>(ref x, ref y);

Console.WriteLine($"x: {x} and y: {y}");

static void Swap<T>(ref T first, ref T second)
{
    T temp = first;
    first = second;
    second = temp;
}*/