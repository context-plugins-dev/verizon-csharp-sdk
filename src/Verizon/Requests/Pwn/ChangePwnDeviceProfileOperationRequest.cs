using Verizon.Models;

namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the ChangePwnDeviceProfile operation.
/// </summary>
public sealed record ChangePwnDeviceProfileOperationRequest
{
    public required ChangePwnDeviceProfileRequest Body { get; init; }
}
