namespace Verizon.Requests.SoftwareManagementReportsV2;

/// <summary>
/// The inputs of the GetCampaignHistoryByStatus operation.
/// </summary>
public sealed record GetCampaignHistoryByStatusRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Status of the campaign.
    /// </summary>
    public required string CampaignStatus { get; init; }

    /// <summary>
    /// Last seen campaign Id.
    /// </summary>
    public string? LastSeenCampaignId { get; init; }
}
