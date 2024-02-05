using MediatR;
using Practical_work_1.Configs.Interfaces;
using Practical_work_1.CQRS.Commands;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class DeleteTraineeHandler : IRequestHandler<DeleteTraineeCommand, Trainee>
    {
        private readonly ITraineeRepository traineeRepository;

        public DeleteTraineeHandler(ITraineeRepository repository, IMediator mediator)
        {
            traineeRepository = repository;
        }

        public async Task<Trainee> Handle(DeleteTraineeCommand request, CancellationToken cancellationToken)
        {
            var result = await traineeRepository.DeleteTrainee(request.id);
            return result;
        }
    }
}
