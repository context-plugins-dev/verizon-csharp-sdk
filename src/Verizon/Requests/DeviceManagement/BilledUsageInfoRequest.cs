using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the BilledUsageInfo operation.
/// </summary>
public sealed record BilledUsageInfoRequest
{
    /// <summary>
    /// Request to list devices with mismatched IMEIs and ICCIDs.
    /// </summary>
    public required BilledusageListRequest Body { get; init; }
}
