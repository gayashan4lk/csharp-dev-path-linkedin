using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Delegates
{
    public class GenericDelegates
    {
        public event Action<string> SomethingHappened;

        // public delegate void Del(string input);

        public void PassMeWork(Action<string> del)
        {
            del("delegates");
        }

        public void PassMeLogic(Func<string, int> worker)
        {
            int count = worker("Hello World");
            Console.WriteLine($"Function returned {count}");
        }

        public void DoSomething()
        {
            Console.WriteLine("About to do something");
            if (SomethingHappened != null)
            {
                SomethingHappened("I did something");
            }
        }
    }
}
