using Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate.ValueObjects;

public sealed class MatchInformation : ValueObject
{
    public static readonly MatchInformation Null = new(new());
    private readonly List<Match> _matches = new();

    public IReadOnlyList<Match> Matches => _matches.AsReadOnly();

    private MatchInformation(List<Match> matches)
    {
        _matches = matches;
    }

    public static MatchInformation Create(List<Match> matches)
    {
        return new MatchInformation(matches);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return _matches;
    }
}