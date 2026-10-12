namespace Verizon.Requests.SoftwareManagementReportsV2;

/// <summary>
/// The inputs of the GetCampaignDeviceStatus operation.
/// </summary>
public sealed record GetCampaignDeviceStatusRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Campaign identifier.
    /// </summary>
    public required string CampaignId { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }
}
