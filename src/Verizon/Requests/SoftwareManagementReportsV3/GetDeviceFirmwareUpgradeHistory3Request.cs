namespace Verizon.Requests.SoftwareManagementReportsV3;

/// <summary>
/// The inputs of the GetDeviceFirmwareUpgradeHistory3 operation.
/// </summary>
public sealed record GetDeviceFirmwareUpgradeHistory3Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Device IMEI identifier.
    /// </summary>
    public required string DeviceId { get; init; }
}
