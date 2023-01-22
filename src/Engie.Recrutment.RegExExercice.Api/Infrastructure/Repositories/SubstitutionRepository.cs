using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;
using Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;

namespace Engie.Recrutment.RegExExercice.Api.Infrastructure.Repositories;

public sealed class SubstitutionRepository : ISubstitutionRepository
{
    private static readonly List<SubstitutionStatement> _db = new();
    public Task<IEnumerable<SubstitutionStatement>> GetAllAsync()
        => Task.FromResult(_db.AsEnumerable());

    public Task SaveAsync(SubstitutionStatement newSubstitution)
        => Task.Run(() =>
            {
                if (!_db.Contains(newSubstitution))
                    _db.Add(newSubstitution);
            });
}