using Verizon.Models;

namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the ChangePwnDeviceIPaddress operation.
/// </summary>
public sealed record ChangePwnDeviceIPaddressOperationRequest
{
    public required ChangePwnDeviceIPaddressRequest Body { get; init; }
}
