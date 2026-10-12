namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the CancelCampaign operation.
/// </summary>
public sealed record CancelCampaignRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Unique identifier of campaign.
    /// </summary>
    public required string CampaignId { get; init; }
}
