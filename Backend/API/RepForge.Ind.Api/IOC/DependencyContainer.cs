using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Security.Claims;
using Azure.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RepForge.Ind.Api.Controllers;
using RepForge.Ind.Domain.Constants;
using static RepForge.Ind.Domain.Common.LoggerExtensions;

namespace RepForge.Ind.Api.IOC;

/// <summary>
/// The Dependency Injection Container Class.
/// </summary>
[ExcludeFromCodeCoverage]
public static class DependencyContainer
{
    /// <summary>
    /// Adds azure services.
    /// </summary>
    /// <param name="builder">The builder.</param>
    /// <param name="credentials">The credentials.</param>
    /// <exception cref="InvalidOperationException">InvalidOperationException error.</exception>
    internal static void ConfigureAzureAppConfiguration(
        this WebApplicationBuilder builder,
        DefaultAzureCredential credentials
    )
    {

    }

    /// <summary>
    /// Configures the application dependencies.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <param name="configuration">The configuration.</param>
    /// <param name="isDevelopmentMode">The development mode.</param>
    internal static void ConfigureApplicationDependencies(
        this IServiceCollection services,
        IConfiguration configuration,
        bool isDevelopmentMode
    )
    {

    }

    #region PRIVATE METHODS

    /// <summary>
    /// Configures the authentication services.
    /// </summary>
    /// <param name="services">The services.</param>
    /// <param name="configuration">The configuration.</param>
    private static void ConfigureAuthenticationServices(
        this IServiceCollection services,
        IConfiguration configuration
    )
    {
        services.AddAuthentication(options =>
        {
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            var tokenFormatUrl = configuration[AzureAppConfigurationConstants.TokenFormatUrlConstant]
                ?? throw new KeyNotFoundException(ExceptionConstants.MissingConfigurationMessage);
            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
            {
                ValidateLifetime = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                RequireExpirationTime = true,
                RequireSignedTokens = true,
                ValidAudience = configuration[AzureAppConfigurationConstants.AzureAdClientIdConstant],
                ValidIssuer = string.Format(
                    CultureInfo.CurrentCulture,
                    tokenFormatUrl,
                    configuration[AzureAppConfigurationConstants.AzureAdTenantIdConstant]
                ),
                SignatureValidator = (token, _) => new Microsoft.IdentityModel.JsonWebTokens.JsonWebToken(jwtEncodedString: token)
            };
            options.Events = new JwtBearerEvents
            {
                OnTokenValidated = HandleAuthTokenValidationSuccessAsync,
                OnAuthenticationFailed = HandleAuthTokenValidationFailedAsync
            };
        });

    }

    /// <summary>
    /// Handles the authentication token validation success asynchronous.
    /// </summary>
    /// <param name="context">The context.</param>
    private static async Task HandleAuthTokenValidationSuccessAsync(
        this TokenValidatedContext context
    )
    {
        var claimsPrincipal = context.Principal;
        if (claimsPrincipal?.Identity is not ClaimsIdentity claimsIdentity || !claimsIdentity.IsAuthenticated)
        {
            var tokenValidationFailedException = new SecurityTokenValidationException(ExceptionConstants.InvalidTokenExceptionConstant);
            context.Fail(failureMessage: tokenValidationFailedException.Message);
            var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<BaseController>>();
            logger.LogAppError(
                exception: tokenValidationFailedException,
                message: tokenValidationFailedException.Message
            );
            return;
        }

        context.HttpContext.User = new ClaimsPrincipal(claimsIdentity);
        await Task.CompletedTask;
    }

    /// <summary>
    /// Handles the authentication token validation failed asynchronous.
    /// </summary>
    /// <param name="context">The context.</param>
    private static async Task HandleAuthTokenValidationFailedAsync(
        this AuthenticationFailedContext context
    )
    {
        var authenticationFailedException = new UnauthorizedAccessException(ExceptionConstants.InvalidTokenExceptionConstant);
        var logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<BaseController>>();
        logger.LogAppError(
            exception: authenticationFailedException,
            message: authenticationFailedException.Message
        );

        context.HttpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
        await context.HttpContext.Response.WriteAsync(
            authenticationFailedException.Message
        ).ConfigureAwait(false);
    }

    #endregion
}
