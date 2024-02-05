using MediatR;
using Practical_work_1.Configs;
using Practical_work_1.CQRS.Commands;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class DeleteTraineeHandler : IRequestHandler<DeleteTraineeCommand, Trainee>
    {
        private readonly ITraineeRepository traineeRepository;
        private readonly IMediator _mediator;

        public DeleteTraineeHandler(ITraineeRepository repository, IMediator mediator)
        {
            traineeRepository = repository;
            _mediator = mediator;
        }

        public async Task<Trainee> Handle(DeleteTraineeCommand request, CancellationToken cancellationToken)
        {
            var result = await traineeRepository.DeleteTrainee(request.id);
            return result;
        }
    }
}
