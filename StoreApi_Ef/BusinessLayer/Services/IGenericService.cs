using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    internal interface IGenericService<T> where T : class
    {
        Task InsertAsync(T item);
        Task UpdateAsync(T item);
        Task DeleteAsync(T item);
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(int id);
    }
}
