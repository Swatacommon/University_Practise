using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_architecture.Models
{
    interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAllPhones();
        T Get(int Id);
        void Add(T item);
        bool Remove(T item);
        void Update(T item);
    }
}
