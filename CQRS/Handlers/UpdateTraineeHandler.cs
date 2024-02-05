using MediatR;
using Practical_work_1.Configs.Interfaces;
using Practical_work_1.CQRS.Commands;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class UpdateTraineeHandler : IRequestHandler<UpdateTraineeCommand, Trainee>
    {
        private readonly ITraineeRepository traineeRepository;

        public UpdateTraineeHandler(ITraineeRepository repository, IMediator mediator)
        {
            traineeRepository = repository;
        }

        public async Task<Trainee> Handle(UpdateTraineeCommand request, CancellationToken cancellationToken)
        {
            Trainee trainee = new Trainee(request.Id, request.TraineeName, request.Age, request.IsWorking);
            return await traineeRepository.UpdateTrainee(trainee);
        }
    }
}
