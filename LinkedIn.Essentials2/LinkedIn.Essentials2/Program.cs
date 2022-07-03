using System.Collections;
using System.Text.Json;
using Essentials2.Generics;
using Essentials2.Collections;
using Essentials2.Exceptions;
using Essentials2.Threading;
using Essentials2.Delegates;
using Essentials2.ExtensionMethods;
using System.Xml.Linq;

/*// LINQ (Language Integrated Query)

var employees = new List<Employee>
{
    new Employee{FirstName = "Matt", LastName = "Manager", Id=1},
    new Employee{FirstName = "Felicia", LastName="FinanceDirector", Id=2},
    new Employee{FirstName = "Pinal", LastName="PropertyManagement", Id=3},
    new Employee{FirstName = "Amanda", LastName = "Accounting", Id=4},
    new Employee{FirstName = "Xi", LastName="CXO", Id=5}
};

// getting an Employee type IEnumerable
var filteredEmployees = employees.Where(e => e.Id > 2).OrderByDescending(e => e.FirstName.Length);
foreach (var emp in filteredEmployees)
{
    // Console.WriteLine(emp.Id);
    Console.WriteLine(emp.ToString());
}

// getting an Anonymous typed IEnumerable
var selectedEmployees = employees.Where(e => e.Id > 2).Select(es => new {FirstName = es.FirstName, LastName = es.LastName});
foreach (var emp in selectedEmployees)
{
    //Console.WriteLine(emp.Id);
    Console.WriteLine(emp.ToString());
}

Console.WriteLine("\n## samething using LINQ ##");

var fEmployees = from emp in employees
                 where emp.Id > 2
                 orderby emp.FirstName.Length
                 descending
                 select emp;

foreach (var emp in fEmployees)
{
    Console.WriteLine(emp.ToString());
}

var sEmployees = from emp in employees
                 where emp.Id > 2
                 select new {FirstName = emp.FirstName, LastName = emp.LastName};
foreach (var emp in sEmployees)
{
    Console.WriteLine(emp.ToString());
}

Console.WriteLine("\n## Read data from XML ##");

var xEmployees = XElement.Load("../../../Employees.xml");

var xEmpLinq = from xemp in xEmployees.Descendants("Employee")
               where (int)xemp.Element("Id") > 2
               select new
               {
                   FirstName = xemp.Element("FirstName").Value,
                   LastName = xemp.Element("LastName").Value,
               };

foreach (var xEmp in xEmpLinq)
{
    Console.WriteLine($"{xEmp.FirstName} {xEmp.LastName}");
}*/

/*// Extension Methods

var result = StringExtensions.Right("teststring", 5);
Console.WriteLine(result);

string str = "this_is_cool";
Console.WriteLine(str.Right(30));

Console.WriteLine("String_class_has_been_extended".Right(17));

var names = new List<string> { "snape", "dumbeldore", "potter", "ron"};

var shortest = names.MinBy(x => x.Length);
Console.WriteLine($"Shortest Name: {shortest}");

var orderedNames = names.OrderBy(x => x.Length);
foreach (var name in orderedNames)
{
    Console.WriteLine(name);
}*/

/*// Lambda expressions as Delegates

var myDelegate = new DelegatesDemo();

myDelegate.PassMeWork(
    (s) => Console.WriteLine($"Hi, Im a lambda as a delegate : {s}"));

var myGenericDelegate = new GenericDelegates();

myGenericDelegate.PassMeWork(
    (s) => Console.WriteLine($"Hi, Im a lambda as a delegate : {s}"));

myGenericDelegate.PassMeLogic(
    (s) => { 
        Console.WriteLine(s); 
        return s.Length; 
    });*/

/*// Lambda expressions

var t = (string s) => Console.WriteLine(s);
t("Hi, I'm a lambda expression");

var t2 = (string s) => s.Length;
Console.WriteLine($"Length of 'hello' : {t2("hello")}");

var c = (string s) =>
{
    Console.WriteLine(s);
    return s.Length;
};

var len = c("Richard");
Console.WriteLine(len);*/

/*// Delegates

Console.WriteLine("Hit CTRL + C to cancel");
Console.CancelKeyPress += onCancel;

Delegate del = WriteHello;
del.DynamicInvoke("Richard");

var delDemo = new DelegatesDemo();
delDemo.PassMeWork(WriteHello);

void WriteHello(string name)
{
    Console.WriteLine($"Hello {name}");
    //delDemo.SomethingHappened -= WriteHello;
}

delDemo.SomethingHappened += WriteHello;
delDemo.DoSomething();

//for (int i = 0; i < 1000000; i++)
//{
//    Console.WriteLine("Writing" + i);
//}

void onCancel(object sender, ConsoleCancelEventArgs e)
{
    e.Cancel = true;
}

Console.WriteLine("\n## Generic Delegates ##");

var gdelDemo = new GenericDelegates();

gdelDemo.PassMeWork(WriteHello);

gdelDemo.PassMeLogic(CaculateLength);

int CaculateLength(string input)
{
    return input.Length;
}*/

/*// Threading
var threadingDemo = new ThreadingDemo();
threadingDemo.SimpleThread();
Console.WriteLine("\n Async Thread");
await threadingDemo.SimpleThreadAsync();*/

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

/* // Exception Handling

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
