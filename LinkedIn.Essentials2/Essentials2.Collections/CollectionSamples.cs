using Essentials2.Generics;
using System.Collections;

namespace Essentials2.Collections
{
    public class CollectionSamples
    {
        public static void Queue()
        {
            var queue = new Queue();
            queue.Enqueue("First item");
            queue.Enqueue("Second item");

            string? item = null;

            Console.WriteLine("QUEUE :");

            while ((item = (string?)queue.Dequeue()) != null)
            {
                Console.WriteLine(item);
                if (queue.Count <= 0)
                {
                    break;
                }
            }
        }

        public static void Stack()
        {
            var stack = new Stack();
            stack.Push("first item");
            stack.Push("Second item");

            string? stackItem = null;
            Console.WriteLine("STACK :");

            while((stackItem = (string?)stack.Pop()) != null)
            {
                Console.WriteLine(stackItem);
                if (stack.Count <= 0)
                    break;
            }
        }

        private static List<Employee> employeeList;

        static CollectionSamples()
        {
            //initialize new customers and add to list
            employeeList = new List<Employee>();

            for (int i = 1; i < 11; i++)
            {
                employeeList.Add(
                    new Employee() 
                    { 
                        Id = i, 
                        FirstName = i.ToString(), 
                        LastName = "Employee", 
                        JoinedDate = new DateOnly(2021, 10, i) 
                    });
            }
        }

        public static void Indexing()
        {
            //get an item at a specific index
            var customerThree = employeeList[2];
            Console.WriteLine($"Found customer {customerThree.Id} at index 2");

            //check if a collection contains an item
            string doesContain = employeeList.Contains(customerThree) ? "does" : "doesn't";
            Console.WriteLine($"Customers {doesContain} contain this customer.");
            //FOLLOW UP: What if you created a new customer object with the same property values?
            //FOLLOW UP: Same as before, but what if customer was a record type or value type instead of a class?

            //use a predicate to find an item in the collection
            var customerSeven = employeeList.Find(EmployeeIsMatch);

            if (customerSeven != null)
            {
                Console.WriteLine($"Found customer {customerSeven.Id}");
            }
            else
            {
                Console.WriteLine("No customer found with that ID.");
            }
        }

        private static bool EmployeeIsMatch(Employee e)
        {
            return e.Id == 7;
            //FOLLOW UP: What happens if your expression matches more than one item?
        }

        public static void Iterating()
        {
            //reverse the order of the list
            employeeList.Reverse();

            IEnumerator<Employee> empBook = employeeList.GetEnumerator();
            while (empBook.MoveNext())
            {
                Employee current = empBook.Current;
                Console.WriteLine($"{current.FirstName} {current.LastName}");
            }

            //sort the customers
            employeeList.Sort();  // or in our case, Reverse would do the same

            //or using foreach
            foreach (var employee in employeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
