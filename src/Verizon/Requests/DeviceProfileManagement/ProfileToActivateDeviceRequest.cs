using Verizon.Models;

namespace Verizon.Requests.DeviceProfileManagement;

/// <summary>
/// The inputs of the ProfileToActivateDevice operation.
/// </summary>
public sealed record ProfileToActivateDeviceRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ProfileRequest Body { get; init; }
}
