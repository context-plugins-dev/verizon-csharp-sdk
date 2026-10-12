using Verizon.Models;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the DailyUsage operation.
/// </summary>
public sealed record DailyUsageRequest
{
    public required DailyUsage Body { get; init; }
}
