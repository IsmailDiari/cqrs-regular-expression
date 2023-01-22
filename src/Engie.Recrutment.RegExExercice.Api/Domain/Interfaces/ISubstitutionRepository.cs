using Engie.Recrutment.RegExExercice.Api.Domain.Aggregates.SubstitutionAggregate;

namespace Engie.Recrutment.RegExExercice.Api.Domain.Interfaces;

public interface ISubstitutionRepository
{
    Task SaveAsync(SubstitutionStatement newSubstitution);
    Task<IEnumerable<SubstitutionStatement>> GetAllAsync();
}