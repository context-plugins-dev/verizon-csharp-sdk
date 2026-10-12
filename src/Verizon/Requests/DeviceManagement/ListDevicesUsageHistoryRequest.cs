using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ListDevicesUsageHistory operation.
/// </summary>
public sealed record ListDevicesUsageHistoryRequest
{
    /// <summary>
    /// Request to obtain usage history for a specific device.
    /// </summary>
    public required DeviceUsageListRequest Body { get; init; }
}
