using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
                .MinimumLength(5)
                .MaximumLength(30)
                .WithMessage("O Título deve conter no mínimo 5 caracteres e no máximo 30 caracteres.");

            RuleFor(p => p.Description)
                .MinimumLength(5)
                .MaximumLength(255)
                .WithMessage("A Descrição deve conter 5 caracteres e no máximo 255 caracteres.");
        }
    }
}
