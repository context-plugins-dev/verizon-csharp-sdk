namespace Verizon.Requests.SoftwareManagementReportsV2;

/// <summary>
/// The inputs of the GetDeviceFirmwareUpgradeHistory2 operation.
/// </summary>
public sealed record GetDeviceFirmwareUpgradeHistory2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Device IMEI identifier.
    /// </summary>
    public required string DeviceId { get; init; }
}
