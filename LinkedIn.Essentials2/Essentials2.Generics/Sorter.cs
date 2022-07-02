using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essentials2.Generics
{
    public class Sorter<T> where T : class, IComparable<T>, new()
    {
        public void Sort(T[] items) 
        {
            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(items[i - 1]) < 0)
                {
                    Swap(items, i, i - 1);
                }
            }
        }

        private void Swap(T[] items, int i, int v)
        {
            T temp = items[i];
            items[i] = items[v];
            items[v] = temp;
        }
    }
}
