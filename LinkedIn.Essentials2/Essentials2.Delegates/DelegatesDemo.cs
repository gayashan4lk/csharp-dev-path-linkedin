using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Delegates
{
    public class DelegatesDemo
    {
        public delegate void Del(string input);

        public void PassMeWork(Del del)
        {
            del("delegates");
        }
    }
}
