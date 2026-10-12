namespace Verizon.Requests.CampaignsV3;

/// <summary>
/// The inputs of the CancelCampaign2 operation.
/// </summary>
public sealed record CancelCampaign2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Firmware upgrade information.
    /// </summary>
    public required string CampaignId { get; init; }
}
