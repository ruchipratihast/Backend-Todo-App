using FluentValidation;
using TodoApp.Models.Request;

namespace TodoApp.Validators
{
    public class CreateTodoValidator:AbstractValidator<CreateTodoRequest>
    {
    public CreateTodoValidator() { 
            RuleFor(x => x.TaskName)
            .NotEmpty().WithMessage("Task name is required.")
            .MaximumLength(100).WithMessage("Task name cannot exceed 100 characters.");
        RuleFor(x => x.DueDate)
            .GreaterThan(DateTime.Now).WithMessage("Due date must be in the future.");
        }
    }
}
