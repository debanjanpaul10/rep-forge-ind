using System;

namespace RepForge.Ind.Domain.Constants;

/// <summary>
/// Contains constants related to environment configuration settings used throughout the application, including keys for application configuration endpoints, managed identity client identifiers, and environment variable names. 
/// These constants facilitate consistent access to configuration values and support environment-specific configurations in the application.
/// </summary>
public static class EnvironmentConfigurationConstants
{
    /// <summary>
    /// The application configuration endpoint key constant
    /// </summary>
    public const string AppConfigurationEndpointKeyConstant = "AppConfigurationEndpoint";

    /// <summary>
    /// The managed identity client identifier constant
    /// </summary>
    public const string ManagedIdentityClientIdConstant = "ManagedIdentityClientId";

    /// <summary>
    /// The Azure Functions environment variable name constant, used to determine the current hosting environment of the Azure Function application (e.g., Development, Staging, Production) and to load the appropriate configuration settings based on that environment.
    /// </summary>
    public const string AzureFunctionsEnvironmentConstant = "AZURE_FUNCTIONS_ENVIRONMENT";

    public const string LocalAppsetingsFileName = "appsettings.development.json";

    public const string ApplicationJsonConstant = "application/json";
}
