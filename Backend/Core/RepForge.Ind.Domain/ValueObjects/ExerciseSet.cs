using RepForge.Ind.Domain.Constants;

namespace RepForge.Ind.Domain.ValueObjects;

/// <summary>
/// Represents a value object for an exercise set, encapsulating the weight and repetitions for a specific exercise.
/// </summary>
public sealed record ExerciseSet
{
    /// <summary>
    /// Gets the weight used in the exercise set. This property is validated to ensure it is not negative, and an exception is thrown if an invalid value is provided.
    /// </summary>
    public decimal Weight { get; private set; }

    /// <summary>
    /// Gets the number of repetitions performed in the exercise set. This property is validated to ensure it is greater than zero, and an exception is thrown if an invalid value is provided.
    /// </summary>
    public int Repetitions { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExerciseSet"/> class. This constructor is private to enforce the use of the public constructor that requires parameters.
    /// </summary>
    private ExerciseSet() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="ExerciseSet"/> class with the specified weight and repetitions. 
    /// This constructor validates the input parameters to ensure they meet the required criteria, throwing an <see cref="ArgumentOutOfRangeException"/> if the weight is negative or if the repetitions are not greater than zero.
    /// </summary>
    /// <param name="weight">The weight used in the exercise set.</param>
    /// <param name="repetitions">The number of repetitions performed in the exercise set.</param>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public ExerciseSet(decimal weight, int repetitions)
    {
        if (weight < 0)
            throw new ArgumentOutOfRangeException(
                nameof(weight),
                ExceptionMessages.NegativeWeight
            );

        if (repetitions <= 0)
            throw new ArgumentOutOfRangeException(
                nameof(repetitions),
                ExceptionMessages.NonPositiveRepetitions
            );

        this.Weight = weight;
        this.Repetitions = repetitions;
    }
}
