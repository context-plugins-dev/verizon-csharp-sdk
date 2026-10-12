using Verizon.Models;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the AggregateUsage operation.
/// </summary>
public sealed record AggregateUsageRequest
{
    public required AggregateUsage Body { get; init; }
}
