using Verizon.Models;

namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the ScheduleSwUpgradeHttpDevices operation.
/// </summary>
public sealed record ScheduleSwUpgradeHttpDevicesRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Device logging information.
    /// </summary>
    public required SchedulesSoftwareUpgradeRequest Body { get; init; }
}
