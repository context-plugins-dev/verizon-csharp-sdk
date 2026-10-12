namespace Verizon.Requests.SoftwareManagementReportsV1;

/// <summary>
/// The inputs of the GetDeviceFirmwareUpgradeHistory operation.
/// </summary>
public sealed record GetDeviceFirmwareUpgradeHistoryRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// The IMEI of the device.
    /// </summary>
    public required string DeviceId { get; init; }
}
