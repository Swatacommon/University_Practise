using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    interface IRepository<T> : IDisposable where T : class 
    {
        IEnumerable<T> GetAll();
        T Get(int ID);
        void Add(T item);
        bool Remove(T item);
        void Update(T item);
    }

}
