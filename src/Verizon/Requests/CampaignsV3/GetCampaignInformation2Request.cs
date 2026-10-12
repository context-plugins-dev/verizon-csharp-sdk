namespace Verizon.Requests.CampaignsV3;

/// <summary>
/// The inputs of the GetCampaignInformation2 operation.
/// </summary>
public sealed record GetCampaignInformation2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Firmware upgrade identifier.
    /// </summary>
    public required string CampaignId { get; init; }
}
