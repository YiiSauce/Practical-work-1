using MediatR;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Queries
{
    public class GetTraineeQuery : IRequest<List<Trainee>>
    {
        IEnumerable<Trainee> _trainee;
    }
}
