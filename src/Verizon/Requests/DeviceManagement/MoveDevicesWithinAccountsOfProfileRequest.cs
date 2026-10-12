using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the MoveDevicesWithinAccountsOfProfile operation.
/// </summary>
public sealed record MoveDevicesWithinAccountsOfProfileRequest
{
    /// <summary>
    /// Request to move devices between accounts.
    /// </summary>
    public required MoveDeviceRequest Body { get; init; }
}
