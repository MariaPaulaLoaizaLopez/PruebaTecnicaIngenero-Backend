using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();  
        Task<TEntity> GetByID(int id);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(int id);
    }
}
