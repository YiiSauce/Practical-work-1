using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using Practical_work_1.Configs.Interfaces;
using Practical_work_1.CQRS.Queries;
using Practical_work_1.Entities;

namespace Practical_work_1.CQRS.Handlers
{
    public class GetTraineeByIdHandler : IRequestHandler<GetTraineeByIdQuery, Trainee>
    {
        private readonly ITraineeRepository traineeRepository;
        public GetTraineeByIdHandler(ITraineeRepository traineeRepository, IMediator mediator)
        {
            this.traineeRepository = traineeRepository;
        }

        public Task<Trainee> Handle(GetTraineeByIdQuery request, CancellationToken cancellationToken)
        {
            return traineeRepository.GetById(request.id);
        }
    }
}
