using GestionLogistica.Database.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLogistica.Database.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private DbContext Context { get; }

        private DbSet<TEntity> DbSet { get; }

        public GenericRepository(DbContext dbContext) 
        {
            Context = dbContext; 
            DbSet = Context.Set<TEntity>();
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<TEntity> GetByID(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task Insert(TEntity entity)
        {
            DbSet.Add(entity);
            await Context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await GetByID(id);

            if(entity != null)
            {
                DbSet.Remove(entity);
            }
            await Context.SaveChangesAsync();
        }

    }
}
