using Verizon.Models;

namespace Verizon.Requests.DeviceProfileManagement;

/// <summary>
/// The inputs of the ActivateDeviceThroughProfile operation.
/// </summary>
public sealed record ActivateDeviceThroughProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ActivateDeviceProfileRequest Body { get; init; }
}
