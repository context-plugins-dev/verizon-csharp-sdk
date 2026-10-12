using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the RetrieveAggregateDeviceUsageHistory operation.
/// </summary>
public sealed record RetrieveAggregateDeviceUsageHistoryRequest
{
    /// <summary>
    /// A request to retrieve aggregated device usage history information.
    /// </summary>
    public required DeviceAggregateUsageListRequest Body { get; init; }
}
