using RepForge.Ind.Domain.ValueObjects;

namespace RepForge.Ind.Domain.Entities;

/// <summary>
/// Represents a logged exercise within a workout session, containing the exercise ID, name, and a collection of sets performed during the session.
/// </summary>
public sealed record LoggedExercise
{
    /// <summary>
    /// Gets the unique identifier of the exercise. This property is initialized to an empty string and is expected to be set during the creation of a LoggedExercise instance.
    /// </summary>
    public string ExerciseId { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the name of the exercise. This property is initialized to an empty string and is expected to be set during the creation of a LoggedExercise instance.
    /// </summary>
    public string ExerciseName { get; private set; } = string.Empty;

    /// <summary>
    /// Gets the collection of exercise sets performed during the workout session. This property is initialized to an empty list and can be populated with instances of <see cref="ExerciseSet"/> representing the weight and repetitions for each set.
    /// </summary>
    public List<ExerciseSet> Sets { get; private set; } = [];

    /// <summary>
    /// Initializes a new instance of the <see cref="LoggedExercise"/> class. 
    /// This constructor is private to enforce the use of the public constructor that requires parameters for exercise ID and name.
    /// </summary>
    private LoggedExercise()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LoggedExercise"/> class with the specified exercise ID and name. 
    /// This constructor sets the properties for the exercise and initializes the collection of sets to an empty list.
    /// </summary>
    /// <param name="exerciseId">The unique identifier of the exercise.</param>
    /// <param name="exerciseName">The name of the exercise.</param>
    public LoggedExercise(string exerciseId, string exerciseName)
    {
        this.ExerciseId = exerciseId;
        this.ExerciseName = exerciseName;
    }

    /// <summary>
    /// Adds a new exercise set to the collection of sets for this logged exercise.
    /// This method creates a new instance of <see cref="ExerciseSet"/> with the specified weight and repetitions, and adds it to the <see cref="Sets"/> collection. 
    /// </summary>
    /// <param name="weight">The weight used for the exercise set.</param>
    /// <param name="reps">The number of repetitions for the exercise set.</param>
    public void AddSet(decimal weight, int reps)
    {
        this.Sets.Add(new ExerciseSet(weight, reps));
    }
}
