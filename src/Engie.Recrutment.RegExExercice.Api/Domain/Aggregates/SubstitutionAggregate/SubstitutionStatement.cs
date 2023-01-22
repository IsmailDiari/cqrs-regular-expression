using System.Text.RegularExpressions;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;

public sealed class SubstitutionStatement : AggregateRoot
{
    private readonly string _pattern;
    private readonly string _text;
    private readonly string _replace;

    public string SubstitutedText { get; private set; }
    public bool? IsSuccess => SubstitutedText is not null and { Length: > 0 };

    private SubstitutionStatement(string pattern, string text, string replace)
        : base(Guid.NewGuid())
    {
        _pattern = pattern;
        _text = text;
        _replace = replace;
    }
    //for automapper
    private SubstitutionStatement() : base(default)
    {

    }
    public static SubstitutionStatement Create(string pattern, string text, string replace)
    {
        _ = pattern ?? throw new BusinessRuleValidationException("PatternShouldNotBeEmptyRule", $"{nameof(pattern)} could not be empty");
        _ = text ?? throw new BusinessRuleValidationException("TextShouldNotBeEmptyRule", $"{nameof(text)} could not be empty");

        return new SubstitutionStatement(pattern, text, replace);
    }
    public void Substitute()
    {
        SubstitutedText ??= Regex.Replace(_text, _pattern, _replace);
    }
}