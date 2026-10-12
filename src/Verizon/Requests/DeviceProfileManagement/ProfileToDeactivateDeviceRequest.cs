using Verizon.Models;

namespace Verizon.Requests.DeviceProfileManagement;

/// <summary>
/// The inputs of the ProfileToDeactivateDevice operation.
/// </summary>
public sealed record ProfileToDeactivateDeviceRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required DeactivateDeviceProfileRequest Body { get; init; }
}
