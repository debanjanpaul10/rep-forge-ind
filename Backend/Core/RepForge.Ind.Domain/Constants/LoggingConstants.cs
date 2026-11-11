namespace RepForge.Ind.Domain.Constants;

/// <summary>
/// Logging constants.
/// </summary>
public class LoggingConstants
{
    public const string CorrelationIdHeader = "X-Correlation-ID";

    public const string LogHelperMethodStart = "{0} started at {1} for {2}";
    public const string LogHelperMethodFailed = "{0} failed at {1} with {2}";
    public const string LogHelperMethodEnd = "{0} ended at {1} for {2}";

    public const string HttpLoggingMessage = "HTTP {Method} {Path} started";

    public const string HttpLoggingMessageWithTime = "HTTP {Method} {Path} responded {StatusCode} in {ElapsedMilliseconds}ms";
    public const string UnhandledExceptionMessage = "Unhandled exception occurred. CorrelationId: {CorrelationId}, Path: {Path}, Method: {Method}";
    public const string NotificationStreamCancelledMessage = "Notification stream cancelled.";
}

/// <summary>
/// The header logging constants class.
/// </summary>
public static class HeaderLoggingConstants
{
    /// <summary>
    /// The correlation id constant.
    /// </summary>
    public const string CorrelationId = "CorrelationId";

    /// <summary>
    /// The request path constant.
    /// </summary>
    public const string RequestPath = "RequestPath";

    /// <summary>
    /// The request method constant.
    /// </summary>
    public const string RequestMethod = "RequestMethod";

    /// <summary>
    /// The status code constant.
    /// </summary>
    public const string StatusCode = "StatusCode";
}