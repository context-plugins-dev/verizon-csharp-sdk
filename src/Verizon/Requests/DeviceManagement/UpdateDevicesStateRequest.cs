using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UpdateDevicesState operation.
/// </summary>
public sealed record UpdateDevicesStateRequest
{
    /// <summary>
    /// Request to change device state to one defined by the user.
    /// </summary>
    public required GoToStateRequest Body { get; init; }
}
