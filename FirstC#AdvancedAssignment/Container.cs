using System;
using System.Collections.Generic;
using System.Text;

namespace FirstC_AdvancedAssignment
{
    internal class Container<T>
    {
       private List<T> items = new List<T>();
        public void Add(T item) {

            items.Add(item);
        }
        public T get(int index)
        {

            return items[index];
        }
        public static void Swap<Z>(ref Z a, ref Z b)
        {
            Z temp = a;
            a = b;
            b = temp;
        }



    }
}
