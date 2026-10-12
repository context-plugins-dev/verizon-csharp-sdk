using Verizon.Models;

namespace Verizon.Requests.DeviceCredentialManagement;

/// <summary>
/// The inputs of the DropCredentials operation.
/// </summary>
public sealed record DropCredentialsRequest
{
    public required CredentialsRequest Body { get; init; }
}
