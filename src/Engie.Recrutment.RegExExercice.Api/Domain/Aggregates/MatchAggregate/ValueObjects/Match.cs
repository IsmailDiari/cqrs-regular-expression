using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;

public sealed class Match : ValueObject
{
    public string MatchedText { get; }
    public int Index { get; }
    private Match(string matchedText, int index)
    {
        MatchedText = matchedText;
        Index = index;
    }

    public static Match Create(string matchedText, int index)
    {
        return new Match(matchedText, index);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Index;
        yield return MatchedText;
    }
}