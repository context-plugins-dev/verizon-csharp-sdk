using Verizon.Models;

namespace Verizon.Requests.SensorInsightsNotificationGroups;

/// <summary>
/// The inputs of the SensorInsightsDeleteNotificationGroup operation.
/// </summary>
public sealed record SensorInsightsDeleteNotificationGroupRequest
{
    /// <summary>
    /// Payload for the delete request.
    /// </summary>
    public required DtoDeleteNotificationGroupRequest Payload { get; init; }
}
