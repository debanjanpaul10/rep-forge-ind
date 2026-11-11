using Azure.Identity;
using RepForge.Ind.Domain.Constants;

var builder = WebApplication.CreateBuilder(args);
if (builder.Environment.IsDevelopment())
    builder.Configuration.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile(EnvironmentConfigurationConstants.LocalAppsetingsFileName, true)
        .AddEnvironmentVariables();

var managedIdentityCredentials = builder.Configuration[EnvironmentConfigurationConstants.ManagedIdentityClientIdConstant];
var credentials = builder.Environment.IsDevelopment()
    ? new DefaultAzureCredential()
    : new DefaultAzureCredential(new DefaultAzureCredentialOptions
    {
        ManagedIdentityClientId = managedIdentityCredentials,
    });