using Verizon.Models;

namespace Verizon.Requests.FirmwareV3;

/// <summary>
/// The inputs of the SynchronizeDeviceFirmware operation.
/// </summary>
public sealed record SynchronizeDeviceFirmwareRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// DeviceIds to get firmware info synchronously.
    /// </summary>
    public required FirmwareImei Body { get; init; }
}
