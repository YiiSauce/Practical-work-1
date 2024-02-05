using MediatR;
using Microsoft.EntityFrameworkCore;
using Practical_work_1.Configs;
using Practical_work_1.CQRS.Queries;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class GetTraineeHandler : IRequestHandler<GetTraineeQuery, List<Trainee>>
    {
        private readonly ITraineeRepository traineeRepository;
        public GetTraineeHandler(ITraineeRepository traineeRepository)
        {
            this.traineeRepository = traineeRepository;
        }
        public Task<List<Trainee>> Handle(GetTraineeQuery request, CancellationToken cancellationToken)
        {
            return traineeRepository.GetAll().ToListAsync();
        }
    }
}
