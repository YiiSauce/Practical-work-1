using MediatR;
using Practical_work_1.Configs;
using Practical_work_1.CQRS.Commands;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class AddTraineeHandler : IRequestHandler<AddTraineeCommand, Trainee>
    {
       private readonly ITraineeRepository traineeRepository;

        public AddTraineeHandler(ITraineeRepository repository, IMediator mediator)
        {
            traineeRepository = repository;
        }

        public async Task<Trainee> Handle(AddTraineeCommand request, CancellationToken cancellationToken)
        {
            var result = await traineeRepository.CreateTrainee(request.trainee);
            return result;
        }
    }
}
    