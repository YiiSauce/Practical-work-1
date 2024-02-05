namespace Practical_work_1.Configs.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetById(long id);
        IQueryable<T> GetAll();
        Task Add(T entity);
        void Delete(T entity);
        void Update(T entity, long id);
    }
}
