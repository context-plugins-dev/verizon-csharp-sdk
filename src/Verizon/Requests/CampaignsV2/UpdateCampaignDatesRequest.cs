namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the UpdateCampaignDates operation.
/// </summary>
public sealed record UpdateCampaignDatesRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Software upgrade information.
    /// </summary>
    public required string CampaignId { get; init; }
}
