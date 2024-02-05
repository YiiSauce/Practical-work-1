using Practical_work_1.Entities;

namespace Practical_work_1.Configs.Interfaces
{
    public interface ITraineeRepository : IGenericRepository<Trainee>
    {
        Task<Trainee> CreateTrainee(Trainee trainee);
        Task<Trainee> DeleteTrainee(long id);
        Task<Trainee> UpdateTrainee(Trainee trainee);
        Task<Trainee> GetById(long id);
    }
}
