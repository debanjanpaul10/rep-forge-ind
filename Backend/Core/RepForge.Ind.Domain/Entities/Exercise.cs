using RepForge.Ind.Domain.Common;
using RepForge.Ind.Domain.Enums;

namespace RepForge.Ind.Domain.Entities;

/// <summary>
/// Represents an exercise entity with properties such as name and muscle group.
/// </summary>
/// <seealso cref="BaseEntity"/>
public sealed record Exercise : BaseEntity
{
    /// <summary>
    /// Gets the name of the exercise.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the muscle group targeted by the exercise.
    /// </summary>
    public MuscleGroup MuscleGroup { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exercise"/> class.
    /// </summary>
    private Exercise() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="Exercise"/> class with the specified name and muscle group.
    /// </summary>
    /// <param name="name">The name of the exercise.</param>
    /// <param name="muscleGroup">The muscle group targeted by the exercise.</param>
    public Exercise(string name, MuscleGroup muscleGroup)
    {
        this.Name = name;
        this.MuscleGroup = muscleGroup;
    }
}
