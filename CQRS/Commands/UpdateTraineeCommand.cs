using MediatR;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Commands
{
    public class UpdateTraineeCommand : IRequest<Trainee>
    {
        public long Id { get; set; }
        public string TraineeName { get; set; }
        public int Age { get; set; }
        public bool IsWorking { get; set; }
    }
}
