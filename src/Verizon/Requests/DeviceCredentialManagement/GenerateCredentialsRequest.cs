using Verizon.Models;

namespace Verizon.Requests.DeviceCredentialManagement;

/// <summary>
/// The inputs of the GenerateCredentials operation.
/// </summary>
public sealed record GenerateCredentialsRequest
{
    public required CredentialsRequest Body { get; init; }
}
