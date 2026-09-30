using System;
using System.Collections.Generic;
using System.Text;

namespace FirstC_AdvancedAssignment
{
    internal interface IRepo<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T GetById(int id);
    }
}
