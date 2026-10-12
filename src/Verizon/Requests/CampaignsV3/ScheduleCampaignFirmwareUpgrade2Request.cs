using Verizon.Models;

namespace Verizon.Requests.CampaignsV3;

/// <summary>
/// The inputs of the ScheduleCampaignFirmwareUpgrade2 operation.
/// </summary>
public sealed record ScheduleCampaignFirmwareUpgrade2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Firmware upgrade information.
    /// </summary>
    public required CampaignFirmwareUpgrade Body { get; init; }
}
