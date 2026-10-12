using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsUpdateNotificationGroupRequest operation.
/// </summary>
public sealed record SensorInsightsUpdateNotificationGroupRequest
{
    /// <summary>
    /// Partially update a notification group
    /// </summary>
    public required DtoUpdateNotificationGroupRequest Body { get; init; }
}
