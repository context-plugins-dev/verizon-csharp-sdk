using Verizon.Models;

namespace Verizon.Requests.DeviceCredentialManagement;

/// <summary>
/// The inputs of the RetrieveCredentials operation.
/// </summary>
public sealed record RetrieveCredentialsRequest
{
    public required CredentialsRequest Body { get; init; }
}
