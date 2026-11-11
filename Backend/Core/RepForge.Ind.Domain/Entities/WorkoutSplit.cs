using RepForge.Ind.Domain.Common;
using RepForge.Ind.Domain.Enums;

namespace RepForge.Ind.Domain.Entities;

/// <summary>
/// Represents a workout split entity that defines a specific training day, its name, and the associated exercises.
/// </summary>
/// <seealso cref="BaseEntity"/>
public sealed record WorkoutSplit : BaseEntity
{
    /// <summary>
    /// Gets the training day associated with this workout split.
    /// </summary>
    public TrainingDay Day { get; private set; }

    /// <summary>
    /// Gets the name of the workout split.
    /// </summary>
    public string Name { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the collection of exercise IDs associated with this workout split. This property is initialized to an empty collection to ensure it is never null.
    /// </summary>
    public IEnumerable<string> ExerciseIds { get; private set; } = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutSplit"/> class. This constructor is private to enforce the use of the public constructor that requires parameters.
    /// </summary>
    private WorkoutSplit() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutSplit"/> class with the specified training day and name.
    /// </summary>
    /// <param name="day">The training day associated with the workout split.</param>
    /// <param name="name">The name of the workout split.</param>
    public WorkoutSplit(TrainingDay day, string name)
    {
        this.Day = day;
        this.Name = name;
    }

    /// <summary>
    /// Adds an exercise ID to the collection of exercises associated with this workout split. If the exercise ID already exists in the collection, it will not be added again.
    /// </summary>
    /// <param name="exerciseId">The ID of the exercise to add.</param>
    public void AddExercise(string exerciseId)
    {
        if (!this.ExerciseIds.Contains(exerciseId))
            this.ExerciseIds = this.ExerciseIds.Append(exerciseId);
    }

    /// <summary>
    /// Removes an exercise ID from the collection of exercises associated with this workout split.
    /// </summary>
    /// <param name="exerciseId">The ID of the exercise to remove.</param>
    public void RemoveExercise(string exerciseId)
    {
        if (this.ExerciseIds.Contains(exerciseId))
            this.ExerciseIds = this.ExerciseIds.Where(id => id != exerciseId);
    }
}
