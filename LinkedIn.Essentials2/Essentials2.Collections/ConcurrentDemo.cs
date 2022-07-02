using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;
using Essentials2.Generics;

namespace Essentials2.Collections
{
    public class ConcurrentDemo
    {
        ConcurrentBag<Person> bag = new ConcurrentBag<Person>();

        public ConcurrentDemo()
        {
            bag.Add(new Person
            {
                Id = 11111,
                FirstName = "Larry",
                LastName = "Page",
                Age = 65,
            });

            bag.Add(new Person
            {
                Id = 2521,
                FirstName = "Jimmy",
                LastName = "Kimmel",
                Age = 65,
            });
        }

        public void PrintAllElements()
        {
            foreach (var item in bag)
            {
                Console.WriteLine($"{item.Id} : {item.FirstName} {item.LastName}");
            }
        }
    }
}
