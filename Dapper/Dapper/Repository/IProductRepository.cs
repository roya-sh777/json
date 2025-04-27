using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Repository
{
    public  interface IProductRepository<T> where T : BaseEntity
    {
        Task AddAsync (T entity);
        Task UpdateAsync (T entity);
        Task DeleteAsync (T entity);
        Task<T?> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync ();
    }

    public class BaseEntity
    {
    }
}
