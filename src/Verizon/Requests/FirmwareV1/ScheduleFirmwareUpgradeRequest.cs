using Verizon.Models;

namespace Verizon.Requests.FirmwareV1;

/// <summary>
/// The inputs of the ScheduleFirmwareUpgrade operation.
/// </summary>
public sealed record ScheduleFirmwareUpgradeRequest
{
    /// <summary>
    /// Details of the firmware upgrade request.
    /// </summary>
    public required FirmwareUpgradeRequest Body { get; init; }
}
