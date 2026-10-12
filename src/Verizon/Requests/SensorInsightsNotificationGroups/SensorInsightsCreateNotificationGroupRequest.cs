using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsCreateNotificationGroupRequest operation.
/// </summary>
public sealed record SensorInsightsCreateNotificationGroupRequest
{
    /// <summary>
    /// Create a notification group
    /// </summary>
    public required DtoCreateNotificationGroupRequest Body { get; init; }
}
