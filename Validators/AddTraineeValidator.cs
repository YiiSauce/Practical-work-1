using FluentValidation;
using Practical_work_1.CQRS.Commands;

namespace Practical_work_1.Validators
{
    public class AddTraineeValidator : AbstractValidator<AddTraineeCommand>
        {
        public AddTraineeValidator() { 
            RuleFor(command => command.TraineeName).NotEmpty().WithMessage("Enter a valid name !!")
                .MinimumLength(5).WithMessage("Name must be longer than 5 characters")
                .MaximumLength(100).WithMessage("Name must not exceed 100 characters");
            RuleFor(command => command.Age).NotNull().WithMessage("Enter a valid Age !!").GreaterThanOrEqualTo(18).WithMessage("the trainee must be an adult");
        }
    }
}
