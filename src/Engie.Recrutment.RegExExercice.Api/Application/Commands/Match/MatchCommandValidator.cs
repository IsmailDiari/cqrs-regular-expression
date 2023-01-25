using FluentValidation;

namespace Engie.Recrutment.RegExExercice.Api.Application.Commands.Match;

public sealed class MatchCommandValidator : AbstractValidator<MatchCommand>
{
    public MatchCommandValidator()
    {
        RuleFor(m => m.Pattern)
            .NotEmpty().WithMessage("{PropertyName} should not be empty");
        RuleFor(m => m.Text)
            .NotEmpty().WithMessage("{PropertyName} should not be empty");
    }
}