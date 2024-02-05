using MediatR;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Queries
{
    public class GetTraineeByIdQuery : IRequest<Trainee>
    {
        public long id { get; set; }
    }
}