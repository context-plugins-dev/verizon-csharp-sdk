using Verizon.Models;

namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the ChangePwnDeviceStateDeactivate operation.
/// </summary>
public sealed record ChangePwnDeviceStateDeactivateOperationRequest
{
    public required ChangePwnDeviceStateDeactivateRequest Body { get; init; }
}
