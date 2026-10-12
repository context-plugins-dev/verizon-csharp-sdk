using Verizon.Models;

namespace Verizon.Requests.CampaignsV2;

/// <summary>
/// The inputs of the ScheduleFileUpgrade operation.
/// </summary>
public sealed record ScheduleFileUpgradeRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Device logging information.
    /// </summary>
    public required UploadAndScheduleFileRequest Body { get; init; }
}
