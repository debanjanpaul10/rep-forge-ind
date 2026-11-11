using RepForge.Ind.Domain.Common;

namespace RepForge.Ind.Domain.Entities;

/// <summary>
/// Represents a workout session entity, encapsulating the details of a workout including the date, split name, exercises performed, and any additional notes. 
/// This entity is part of the domain layer and inherits from <see cref="BaseEntity"/> to include common properties such as an identifier and timestamps.
/// </summary>
public sealed record WorkoutSession : BaseEntity
{
    /// <summary>
    /// Gets the date of the workout session. 
    /// This property is of type <see cref="DateOnly"/> to represent the date without time information, ensuring that the workout session is associated with a specific day.
    /// </summary>
    public DateOnly WorkoutDate { get; private set; }

    /// <summary>
    /// Gets the name of the workout split associated with this session.
    /// </summary>
    public string SplitName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the collection of logged exercises performed during the workout session.
    /// </summary>
    public List<LoggedExercise> Exercises { get; private set; } = [];

    /// <summary>
    /// Gets any additional notes associated with the workout session, allowing for the recording of observations, comments, or other relevant information.
    /// </summary>
    public string Notes { get; private set; } = string.Empty;

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutSession"/> class.
    /// </summary>
    private WorkoutSession()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkoutSession"/> class with the specified workout date and split name.
    /// </summary>
    /// <param name="workoutDate">The date of the workout session.</param>
    /// <param name="splitName">The name of the workout split associated with this session.</param>
    public WorkoutSession(DateOnly workoutDate, string splitName)
    {
        this.WorkoutDate = workoutDate;
        this.SplitName = splitName;
    }

    /// <summary>
    /// Adds a new logged exercise to the collection of exercises for this workout session.
    /// </summary>
    /// <param name="exercise">The logged exercise to add.</param>
    public void AddExercise(LoggedExercise exercise)
    {
        this.Exercises.Add(exercise);
    }

    /// <summary>
    /// Adds a note to the workout session, allowing for the recording of observations, comments, or other relevant information.
    /// </summary>
    /// <param name="note">The note to add.</param>
    public void AddNote(string note)
    {
        this.Notes = note;
    }
}
