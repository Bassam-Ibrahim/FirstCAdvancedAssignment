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
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) > 0 ? a : b;
        }



    }
}
