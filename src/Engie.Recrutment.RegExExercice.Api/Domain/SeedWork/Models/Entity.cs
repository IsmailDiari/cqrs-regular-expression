namespace Engie.Recrutment.RegExExercice.Api.Domain.SeedWork.Models;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; protected set; }
    protected Entity(Guid id) => Id = id;

    public override bool Equals(object? obj)
        => obj is Entity other && Id.Equals(other.Id);
    public bool Equals(Entity? other)
        => Equals((object?)other);
    public static bool operator ==(Entity left, Entity right)
        => Equals(left, right);
    public static bool operator !=(Entity left, Entity right)
        => !Equals(left, right);

    public override int GetHashCode()
        => Id.GetHashCode();
}