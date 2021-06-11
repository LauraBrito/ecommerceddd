using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface IGenericApp<T> where T : class
    {
        Task Add(T Object);
        Task Update(T Object);
        Task Delete(T Object);
        Task<T> GetEntityById(Guid id);
        Task<List<T>> List();
    }
}
