using MediatR;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Commands
{
    public class DeleteTraineeCommand : IRequest<Trainee>
    {
        public long id { get; set; }
    }
}
