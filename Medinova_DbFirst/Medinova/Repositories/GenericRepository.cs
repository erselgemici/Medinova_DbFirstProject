using Medinova.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Medinova.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        MedinovaContext db = new MedinovaContext();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = db.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            var addedEntity = db.Entry(entity);
            addedEntity.State = EntityState.Added;
            await db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var value = await _object.FindAsync(id);           
            _object.Remove(value);

            await db.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _object.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _object.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            var updatedEntity = db.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            await db.SaveChangesAsync();
        }
    }
}
