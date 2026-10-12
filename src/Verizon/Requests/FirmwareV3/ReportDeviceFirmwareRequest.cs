namespace Verizon.Requests.FirmwareV3;

/// <summary>
/// The inputs of the ReportDeviceFirmware operation.
/// </summary>
public sealed record ReportDeviceFirmwareRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Device identifier.
    /// </summary>
    public required string DeviceId { get; init; }
}
