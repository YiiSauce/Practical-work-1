using MediatR;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Commands
{
    public class AddTraineeCommand : IRequest<Trainee>
    {
        public Trainee trainee {  get; set; }
    }
}
