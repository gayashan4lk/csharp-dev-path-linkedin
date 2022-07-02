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
    }
}