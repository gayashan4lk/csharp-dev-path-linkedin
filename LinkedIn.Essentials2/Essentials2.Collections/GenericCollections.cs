using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Collections
{
    public class GenericCollections
    {
        public static void Stack()
        {
            var stack = new Stack<string>();
            stack.Push("first item");
            stack.Push("Second item");

            string? stackItem = null;
            Console.WriteLine("Stack<string> :");

            while((stackItem = stack.Pop()) != null)
            {
                Console.WriteLine(stackItem);
                if (stack.Count <= 0)
                    break;
            }
        }
    }
}
