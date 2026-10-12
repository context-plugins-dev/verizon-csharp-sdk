using Verizon.Models;

namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the ChangePwnDeviceStateActivate operation.
/// </summary>
public sealed record ChangePwnDeviceStateActivateOperationRequest
{
    public required ChangePwnDeviceStateActivateRequest Body { get; init; }
}
