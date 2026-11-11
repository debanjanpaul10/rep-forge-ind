using System;

namespace RepForge.Ind.Application.Abstractions;

/// <summary>
/// Provides access to the correlation ID for the current request context across all application layers.
/// </summary>
public interface ICorrelationContext
{
    /// <summary>
    /// Gets the correlation ID for the current request.
    /// </summary>
    string CorrelationId { get; }
}
