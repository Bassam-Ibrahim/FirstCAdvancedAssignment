using System;
using System.Collections.Generic;
using System.Text;

namespace FirstC_AdvancedAssignment
{
    public class SafeList<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
                return default(T);

            return items[index];
        }
    }
}
