using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the GetDeviceServiceSuspensionStatus operation.
/// </summary>
public sealed record GetDeviceServiceSuspensionStatusRequest
{
    /// <summary>
    /// Request to obtain service suspenstion status for a device.
    /// </summary>
    public required DeviceSuspensionStatusRequest Body { get; init; }
}
