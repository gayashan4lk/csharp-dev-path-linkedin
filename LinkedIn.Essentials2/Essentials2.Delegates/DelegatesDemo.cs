using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Delegates
{
    public class DelegatesDemo
    {
        public event Del SomethingHappened;

        public delegate void Del(string input);

        public void PassMeWork(Del del)
        {
            del("IM THE INPUT");
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
