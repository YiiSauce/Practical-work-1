using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Practical_work_1.Configs;
using Practical_work_1.CQRS.Commands;
using Practical_work_1.CQRS.Queries;
using Practical_work_1.Entities;

namespace Practical_work_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TraineesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/Trainees
        [HttpGet]
        public async Task<IActionResult> GetTrainee()
        {
            var trainees = await _mediator.Send(new GetTraineeQuery());
            return Ok(trainees);
        }

        // GET: api/Trainees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Trainee>> GetTraineeById(long id)
        {
            var traineeQuery = new GetTraineeByIdQuery() { id = id };
            var trainee = await _mediator.Send(traineeQuery);
            return Ok(trainee);
        }

        // POST: api/Trainees
        [HttpPost]
        public async Task<ActionResult<Trainee>> PostTrainee(Trainee trainee)
        {
            var traineeCommand = new AddTraineeCommand() { trainee = trainee };
            var trainees = await _mediator.Send(traineeCommand);
            return Ok(trainees);
        }

        // DELETE: api/Trainees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrainee(long id)
        {
            var traineeCommand = new DeleteTraineeCommand() {id = id};
            var traineeRep = await _mediator.Send(traineeCommand);
            return Ok(traineeRep);
        }
        // UPDATE: api/Trainees/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTrainee(long id, Trainee trainee)
        {
            var traineeCommand = new UpdateTraineeCommand() { trainee = trainee, id = id};
            var traineeRep = await _mediator.Send(traineeCommand);

            return Ok(traineeRep);
        }
    }
}
