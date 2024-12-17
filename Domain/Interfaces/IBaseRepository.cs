using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        public Task<IEnumerable<TEntity>> GetAll();
        public Task<TEntity> Get(int id);
        public Task Create(TEntity entity);
        public Task Update(TEntity entity);
        public Task Delete(int id);
        public Task DeleteAll();
    }
}
