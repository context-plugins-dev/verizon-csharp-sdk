namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the UpdateCampaignFirmwareDevices operation.
/// </summary>
public sealed record UpdateCampaignFirmwareDevicesRequest
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
