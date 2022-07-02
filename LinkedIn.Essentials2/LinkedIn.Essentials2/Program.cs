using Essentials2.Generics;

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
}