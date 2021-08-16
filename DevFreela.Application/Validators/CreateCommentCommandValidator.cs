using DevFreela.Application.Commands.CreateComment;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {
        public CreateCommentCommandValidator()
        {
            RuleFor(p => p.Content)
                .MinimumLength(10)
                .MaximumLength(255)
                .WithMessage("O conteúdo da mensagem deve conter no mínimo 10 caracteres e no máximo 255 caractered.");
        }
    }
}
