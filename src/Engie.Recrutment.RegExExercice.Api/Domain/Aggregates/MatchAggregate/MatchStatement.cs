using System.Text.RegularExpressions;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Exceptions;
using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

using DomainMatch = Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects.Match;
using RegexMatch = System.Text.RegularExpressions.Match;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;

public sealed class MatchStatement : AggregateRoot
{
    private readonly string _pattern;
    private readonly string _text;

    public MatchInformation MatchInformation { get; private set; } = MatchInformation.Null;
    public bool? IsSuccess => MatchInformation != MatchInformation.Null;

    private MatchStatement(string pattern, string text)
        : base(Guid.NewGuid())
    {
        _pattern = pattern;
        _text = text;
    }

    public static MatchStatement Create(string pattern, string text)
    {
        _ = !string.IsNullOrWhiteSpace(pattern) ? pattern : throw new BusinessRuleValidationException("PatternShouldNotBeEmptyRule", $"{nameof(pattern)} could not be null");
        _ = !string.IsNullOrWhiteSpace(text) ? text : throw new BusinessRuleValidationException("TextShouldNotBeEmptyRule", $"{nameof(text)} could not be null");

        return new MatchStatement(pattern, text);
    }

    public void Match()
    {
        if (MatchInformation == MatchInformation.Null)
        {
            var matches = new List<DomainMatch>();
            foreach (RegexMatch match in Regex.Matches(_text, _pattern))
            {
                matches.Add(DomainMatch.Create(match.Value, match.Index));
            }
            if (matches.Any())
                MatchInformation = MatchInformation.Create(matches);
        }
    }
}