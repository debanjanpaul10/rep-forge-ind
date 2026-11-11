namespace RepForge.Ind.Domain.Common;

/// <summary>
/// Base entity class that provides common properties and methods for all entities in the domain.
/// </summary>
public abstract record BaseEntity
{
    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    public string Id { get; protected set; } = Guid.NewGuid().ToString();

    /// <summary>
    /// Gets the date and time when the entity was created in UTC.
    /// </summary>
    public DateTime CreatedOnUtc { get; protected set; } = DateTime.UtcNow;

    /// <summary>
    /// Gets the date and time when the entity was last modified in UTC. This property is nullable to indicate that the entity may not have been modified since creation.
    /// </summary>
    public DateTime ModifiedOnUtc { get; protected set; } = DateTime.UtcNow;
}
