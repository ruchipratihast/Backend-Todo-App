using FluentValidation;
using TodoApp.Models.Request;

namespace TodoApp.Validators
{
    public class TodoValidator:AbstractValidator<CreateTodoRequest>
    {
    public TodoValidator() { 
            RuleFor(x => x.TaskName)
            .NotEmpty().WithMessage("Task name is required.")
            .MaximumLength(100).WithMessage("Task name cannot exceed 100 characters.");
        RuleFor(x => x.DueDate)
            .GreaterThan(DateTime.Now).WithMessage("Due date must be in the future.");
        }
    }

    public class UpdateTodoValidator:AbstractValidator<UpdateTodoRequest>
    {
        public UpdateTodoValidator() { 
            RuleFor(x => x.Id)
            .NotEmpty().WithMessage("Id is required.");
            RuleFor(x => x.TaskName)
            .NotEmpty().WithMessage("Task name is required.")
            .MaximumLength(100).WithMessage("Task name cannot exceed 100 characters.");
        RuleFor(x => x.DueDate)
            .GreaterThan(DateTime.Now).WithMessage("Due date must be in the future.");
        }
    }
}
