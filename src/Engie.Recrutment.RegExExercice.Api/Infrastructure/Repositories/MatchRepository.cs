using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.MatchAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;

namespace Engie.Recrutment.RegExExercice.Api.Infrastructure.Repositories;

public sealed class MatchRepository : IMatchRepository
{
    private static readonly List<MatchStatement> _db = new();
    public Task<IEnumerable<MatchStatement>> GetAllAsync()
        => Task.FromResult(_db.AsEnumerable());

    public Task SaveAsync(MatchStatement newMatch)
        => Task.Run(() =>
            {
                if (!_db.Contains(newMatch))
                    _db.Add(newMatch);
            });
}