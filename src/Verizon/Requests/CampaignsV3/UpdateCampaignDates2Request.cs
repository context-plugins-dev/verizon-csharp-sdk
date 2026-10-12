using Verizon.Models;

namespace Verizon.Requests.CampaignsV3;

/// <summary>
/// The inputs of the UpdateCampaignDates2 operation.
/// </summary>
public sealed record UpdateCampaignDates2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Firmware upgrade information.
    /// </summary>
    public required string CampaignId { get; init; }

    /// <summary>
    /// New dates and time windows.
    /// </summary>
    public required V3ChangeCampaignDatesRequest Body { get; init; }
}
