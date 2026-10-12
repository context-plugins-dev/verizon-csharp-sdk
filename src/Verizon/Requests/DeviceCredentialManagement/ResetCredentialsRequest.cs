using Verizon.Models;

namespace Verizon.Requests.DeviceCredentialManagement;

/// <summary>
/// The inputs of the ResetCredentials operation.
/// </summary>
public sealed record ResetCredentialsRequest
{
    public required CredentialsRequest Body { get; init; }
}
