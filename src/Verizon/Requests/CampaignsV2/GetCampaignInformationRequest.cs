namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the GetCampaignInformation operation.
/// </summary>
public sealed record GetCampaignInformationRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Software upgrade identifier.
    /// </summary>
    public required string CampaignId { get; init; }
}
