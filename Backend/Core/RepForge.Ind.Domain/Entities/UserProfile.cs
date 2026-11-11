using RepForge.Ind.Domain.Common;

namespace RepForge.Ind.Domain.Entities;

/// <summary>
/// Represents a user profile entity, encapsulating the details of a user's profile including their name, current weight, and target weight.
/// </summary>
/// <seealso cref="BaseEntity"/>
public sealed record UserProfile : BaseEntity
{
    /// <summary>
    /// Gets the name of the user associated with this profile. 
    /// This property is initialized to an empty string and is expected to be set during the creation of a UserProfile instance.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the current weight of the user associated with this profile.
    /// </summary>
    public decimal CurrentWeight { get; private set; }

    /// <summary>
    /// Gets the target weight of the user associated with this profile, representing the user's weight goal.
    /// </summary>
    public decimal TargetWeight { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UserProfile"/> class.
    /// </summary>
    private UserProfile()
    {
    }
}
