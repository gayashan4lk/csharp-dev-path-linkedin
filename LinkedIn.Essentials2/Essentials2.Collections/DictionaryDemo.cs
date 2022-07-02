using Essentials2.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Collections
{
    public class DictionaryDemo
    {
        Dictionary<string, Person> people = new Dictionary<string, Person>();

        public void AddElements()
        {
            people.Add("good person", new Person()
            {
                Id = 102,
                FirstName = "Bruce",
                LastName = "Wayne",
                Age = 35,
            });

            people.Add("bad person", new Person()
            {
                Id = 303,
                FirstName = "Jack",
                LastName = "Napier",
                Age = 22,
            });
        }

        private bool isKeyFound(string key)
        {
            return people.ContainsKey(key);
        }

        public void PrintElementByKey(string key)
        {
            if(!isKeyFound(key))
            {
                Console.WriteLine("Element does not exist!");
            }
            var person = people[key];
            Console.WriteLine($"Person with key {key}: {person.FirstName} {person.LastName}");
        }

        public void PrintAllElements()
        {
            foreach(var person in people)
            {
                Console.WriteLine($"Key: {person.Key}   Value: {person.Value.FirstName} {person.Value.LastName} , {person.Value.Age}, {person.Value.Id}");
            }
        }
    }
}
