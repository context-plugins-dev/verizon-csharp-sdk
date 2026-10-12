namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the ScheduleCampaignFirmwareUpgrade operation.
/// </summary>
public sealed record ScheduleCampaignFirmwareUpgradeRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
