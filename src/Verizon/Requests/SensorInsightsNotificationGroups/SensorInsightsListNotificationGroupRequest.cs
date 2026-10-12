using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsListNotificationGroupRequest operation.
/// </summary>
public sealed record SensorInsightsListNotificationGroupRequest
{
    /// <summary>
    /// Retrieve a notification group
    /// </summary>
    public required DtoListNotificationGroupRequest Body { get; init; }
}
