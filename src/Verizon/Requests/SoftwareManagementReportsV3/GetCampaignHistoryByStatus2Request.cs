using Verizon.Models.Enums;

namespace Verizon.Requests.SoftwareManagementReportsV3;

/// <summary>
/// The inputs of the GetCampaignHistoryByStatus2 operation.
/// </summary>
public sealed record GetCampaignHistoryByStatus2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Campaign status.
    /// </summary>
    public required CampaignStatus CampaignStatus { get; init; }

    /// <summary>
    /// Last seen campaign Id.
    /// </summary>
    public string? LastSeenCampaignId { get; init; }
}
