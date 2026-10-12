namespace Verizon.Requests.SoftwareManagementReportsV3;

/// <summary>
/// The inputs of the GetCampaignDeviceStatus2 operation.
/// </summary>
public sealed record GetCampaignDeviceStatus2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Campaign identifier.
    /// </summary>
    public required string CampaignId { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }
}
