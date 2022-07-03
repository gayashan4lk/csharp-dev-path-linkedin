using System.Collections;
using System.Text.Json;
using Essentials2.Generics;
using Essentials2.Collections;
using Essentials2.Exceptions;
using Essentials2.Threading;

// Threading
var threadingDemo = new ThreadingDemo();
threadingDemo.SimpleThread();
await threadingDemo.SimpleThreadAsync();

/* // Generics
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

Console.WriteLine("\n");


// *************************************************************************************************************************

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

/* // Collections
 
CollectionSamples.Queue();
CollectionSamples.Stack();
GenericCollections.Stack();

Console.WriteLine("\n");

CollectionSamples.Indexing();
CollectionSamples.Iterating();

Console.WriteLine("\n");

string[] names = new string[2];
names[0] = "Darth";
names[1] = "Vader";
Console.WriteLine($"Names Array: {names[0]}, {names[1]}");

var arraylist = new ArrayList(2);

arraylist.Add("First item");
arraylist.AddRange(names);
arraylist.AddRange(new string[] { "Second item", "Third item", "Fourth item" });

Console.WriteLine($"Arraylist size: {arraylist.Count}");
Console.WriteLine($"Indexed item [4]: {arraylist[4]}");
Console.WriteLine("All items in Arraylist");
foreach (var item in arraylist)
{
    Console.WriteLine(item);
}

Console.WriteLine("\n### Dictionary Collections ###");

var dictionary = new DictionaryDemo();
dictionary.AddElements();
dictionary.PrintElementByKey("good person");
dictionary.PrintElementByKey("bad person");
dictionary.PrintAllElements();

Console.WriteLine("\n### Concurrent Collections ###");

var concurrent = new ConcurrentDemo();
concurrent.PrintAllElements();*/

/*// Exception Handling
Console.WriteLine("\n### Exception Handling ###");

var exception = new ExceptionDemo();
exception.BasicExceptions();
//exception.ThrowExceptions(null);
//exception.ThrowExceptions(true);

try
{
    exception.ThrowExceptions(null);
}
catch (Exception ex)
{
    Console.WriteLine($"Null EXCEPTION: {ex}");
}

try
{
    exception.ThrowExceptions(true);
}
catch (Exception ex)
{
    Console.WriteLine($"JUST THROWING: {ex}");
    //throw;
}

try
{
    exception.ThrowExceptions(true);
}
catch (Exception ex)
{
    Console.WriteLine($"JUST THROWING: {ex}");
    throw new ApplicationException("app exception", ex);
}*/
