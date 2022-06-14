using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Essentials
{
    public static class CloningObjectsDriver
    {
        public static void Classes()
        {
            Console.WriteLine("\n =========== Classes = reference types ===========");
            //Create an employee
            Employee me = new Employee
            {
                FirstName = "Matt",
                LastName = "Milner",
                Age = new Age { BirthDate = new DateOnly(1971, 9, 1), YearsOld = 50 },
                Id = 1
            };
            Console.WriteLine($"[ME] => Name: {me.FirstName} {me.LastName}, Age: {me.Age.YearsOld}, BirthDate: {me.Age.BirthDate}, Id: {me.Id}");

            //create another reference to the employee
            IPerson other = me;
            other.FirstName = "Bizarro";
            other.LastName = "Bonesara";
            other.Age = new Age { BirthDate = new DateOnly(2000, 1, 1), YearsOld = 10 };
            other.Id = 999;
            Console.WriteLine($"[OTHER] => Name: {other.FirstName} {other.LastName}, Age: {other.Age.YearsOld}, BirthDate: {other.Age.BirthDate}, Id: {other.Id}");
            Console.WriteLine($"[ME after creating OTHER] => Name: {me.FirstName} {me.LastName}, Age: {me.Age.YearsOld}, BirthDate: {me.Age.BirthDate}, Id: {me.Id}");

            ChangeName(other);
            Console.WriteLine($"[OTHER after exe method] => Name: {other.FirstName} {other.LastName}, Age: {other.Age.YearsOld}, BirthDate: {other.Age.BirthDate}, Id: {other.Id}");
        }

        static void ChangeName(IPerson person)
        {
            person.LastName = "Unknown";
            Console.WriteLine($"[PERSON in method] => Name: {person.FirstName} {person.LastName}, Age: {person.Age.YearsOld}, BirthDate: {person.Age.BirthDate}, Id: {person.Id}");

            person = new Manager("Manager", "Milner")
            {
                Id = 2,
                Age = new Age { BirthDate = new DateOnly(1990, 1, 1), YearsOld = 31 }
            };

            Console.WriteLine($"[PERSON after reference change] => Name: {person.FirstName} {person.LastName}, Age: {person.Age.YearsOld}, BirthDate: {person.Age.BirthDate}, Id: {person.Id}");
        }

        public static void Structs()
        {
            Console.WriteLine("\n=========== Structs = value types ===========");

            Age myAge = new Age { BirthDate = new DateOnly(1971, 9, 1), YearsOld = 50 };
            Console.WriteLine($"[myAge] => Birthdate: {myAge.BirthDate}, Age: {myAge.YearsOld}");
            Age anotherAge = myAge;
            Console.WriteLine($"[anotherAge] => Birthdate: {anotherAge.BirthDate}, Age: {anotherAge.YearsOld}");

            anotherAge.YearsOld = 39;
            anotherAge.BirthDate = new DateOnly(2000, 3, 3);

            Console.WriteLine("AnotherAge changed...");
            Console.WriteLine($"[MyAge] => Birthdate: {myAge.BirthDate}, Age: {myAge.YearsOld}");
            Console.WriteLine($"[anotherAge] => Birthdate: {anotherAge.BirthDate}, Age: {anotherAge.YearsOld}");

            AgeBackwords(ref anotherAge, 10);
            Console.WriteLine($"[anotherAge after method] => Birthdate: {anotherAge.BirthDate}, Age: {anotherAge.YearsOld}");
        }

        static void AgeBackwords(ref Age startingAge, int numberOfYearsToAge)
        {
            startingAge.YearsOld -= numberOfYearsToAge;
            Console.WriteLine($"Modified age in method: {startingAge.YearsOld}");
        }

        public static void Records()
        {
            Console.WriteLine("\n=========== Records = reference or value types ===========");

            PremiereCustomer pc = new PremiereCustomer
            {
                FirstName = "Customer",
                LastName = "One",
                Id = 7,
                Age = new Age { BirthDate = new DateOnly(1999, 9, 9), YearsOld = 1 },
                CustomerLevel = 1
            };

            PremiereCustomer pc2 = pc with { CustomerLevel = 2, LastName = "Two" };

            Console.WriteLine($"{pc.FirstName} {pc.LastName} has a level of {pc.CustomerLevel}");
            Console.WriteLine($"{pc2.FirstName} {pc2.LastName} has a level of {pc2.CustomerLevel}");
            ChangeName((IPerson)pc);
            Console.WriteLine($"{pc.FirstName} {pc.LastName} is still {pc.Age.YearsOld}");

        }
    }
}
