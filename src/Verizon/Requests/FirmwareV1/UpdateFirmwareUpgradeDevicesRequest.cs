namespace Verizon.Requests.FirmwareV1;

/// <summary>
/// The inputs of the UpdateFirmwareUpgradeDevices operation.
/// </summary>
public sealed record UpdateFirmwareUpgradeDevicesRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// The UUID of the upgrade, returned by POST /upgrades when the upgrade was scheduled.
    /// </summary>
    public required string UpgradeId { get; init; }
}
