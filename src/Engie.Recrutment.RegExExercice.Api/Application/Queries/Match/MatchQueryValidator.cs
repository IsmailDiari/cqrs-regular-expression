using FluentValidation;

namespace Engie.Recrutment.RegExExercice.Api.Application.Queries.MatchQuery;

public sealed class MatchQueryValidator : AbstractValidator<MatchQuery>
{
    public MatchQueryValidator()
    {
        RuleFor(m => m.Pattern)
            .NotEmpty().WithMessage("{PropertyName} should not be empty");
        RuleFor(m => m.Text)
            .NotEmpty().WithMessage("{PropertyName} should not be empty");
    }
}