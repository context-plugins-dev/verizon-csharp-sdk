using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsRemoveUsersFromNotificationGroupRequest operation.
/// </summary>
public sealed record SensorInsightsRemoveUsersFromNotificationGroupRequest
{
    /// <summary>
    /// Remove users from a notification group
    /// </summary>
    public required DtoRemoveUsersFromNotificationGroupRequest Body { get; init; }
}
