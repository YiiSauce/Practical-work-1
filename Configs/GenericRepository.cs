
using Microsoft.EntityFrameworkCore;
using System;

namespace Practical_work_1.Configs
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly TraineeContext _dbContext;

        public GenericRepository(TraineeContext traineeContext)
        {
            _dbContext = traineeContext;
        }
        public Task Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            return Task.CompletedTask;
        }

        public void Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsNoTracking();
        }

        public Task<T> GetById(long id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity, long id)
        {
            //i'm back to it
            throw new NotImplementedException();
        }
    }
}