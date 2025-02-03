using System;

namespace Family.Domain.Entities.Base;

public abstract class Entity<TId>(TId id) : IEquatable<Entity<TId>>  where TId : struct
{
    public TId Id { get; init; } = id;
    
    public override string ToString() => Id.ToString();

    public override bool Equals(object? obj) =>  obj is Entity<TId> other && EqualityComparer<TId>.Default.Equals(Id, other.Id);
    
    public override int GetHashCode() => Id.GetHashCode();
    
    public bool Equals(Entity<TId>? other) => other is not null && EqualityComparer<TId>.Default.Equals(Id, other.Id);
    
    public static bool operator==(Entity<TId> first, Entity<TId> second)
    {
        if(ReferenceEquals(first, second))
            return true;
        return !first.Id.Equals(default(TId)) && first.Equals(second);
    }
    public static bool operator!=(Entity<TId> first, Entity<TId> second) =>!(first == second);
}