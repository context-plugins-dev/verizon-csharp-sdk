namespace Verizon.Requests.FirmwareV1;

/// <summary>
/// The inputs of the CancelScheduledFirmwareUpgrade operation.
/// </summary>
public sealed record CancelScheduledFirmwareUpgradeRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// The UUID of the scheduled upgrade that you want to cancel.
    /// </summary>
    public required string UpgradeId { get; init; }
}
