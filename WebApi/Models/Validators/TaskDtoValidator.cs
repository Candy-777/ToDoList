using FluentValidation;


namespace WebApi.Models.Validators
{
    public class TaskDtoValidator : AbstractValidator<TaskDto>
    {
        public TaskDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Title is required.")
                .MaximumLength(100).WithMessage("The length of the title should not exceed 100 characters");

            RuleFor(x => x.DeadLine)
                .GreaterThan(DateTime.Now).WithMessage("Deadline must be in the future.");
            RuleFor(x => x.Priority).IsInEnum().WithMessage("Priority must be a valid enum value.");

        }
    }
}
