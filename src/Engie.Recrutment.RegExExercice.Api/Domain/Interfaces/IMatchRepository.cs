using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;

public interface IMatchRepository
{
    Task SaveAsync(MatchStatement newMatch);
    Task<IEnumerable<MatchStatement>> GetAllAsync();
}