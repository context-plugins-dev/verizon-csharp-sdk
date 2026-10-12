using Verizon.Models;

namespace Verizon.Requests.CampaignsV3;

/// <summary>
/// The inputs of the UpdateCampaignFirmwareDevices2 operation.
/// </summary>
public sealed record UpdateCampaignFirmwareDevices2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Unique identifier of a campaign.
    /// </summary>
    public required string CampaignId { get; init; }

    /// <summary>
    /// Add or remove device to existing upgrade information.
    /// </summary>
    public required V3AddOrRemoveDeviceRequest Body { get; init; }
}
