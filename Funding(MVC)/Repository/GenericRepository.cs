using Funding_MVC_.Data;
using Funding_MVC_.Interface;
using Microsoft.EntityFrameworkCore;

namespace Funding_MVC_.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class

    {
        private readonly ApplicationDbContext _dbContext;

        public GenericRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(int id) //no <T> because no need to return 
        {
            var entity = await _dbContext.Set<T>().FindAsync(id);  //Set<T>(),  find the matching DBset
            _dbContext.Set<T>().Remove(entity); 
            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
