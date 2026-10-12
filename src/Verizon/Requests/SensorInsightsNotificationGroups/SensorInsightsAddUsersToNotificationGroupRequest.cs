using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsAddUsersToNotificationGroupRequest operation.
/// </summary>
public sealed record SensorInsightsAddUsersToNotificationGroupRequest
{
    /// <summary>
    /// Add users to a notification group
    /// </summary>
    public required DtoAddUsersToNotificationGroupRequest Body { get; init; }
}
