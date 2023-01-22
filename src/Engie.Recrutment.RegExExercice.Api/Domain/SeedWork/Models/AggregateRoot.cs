namespace Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id)
    {
    }
}