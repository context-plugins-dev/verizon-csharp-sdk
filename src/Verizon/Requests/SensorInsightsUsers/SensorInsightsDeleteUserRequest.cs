using Verizon.Models;

namespace Verizon.Requests.SensorInsightsUsers;

/// <summary>
/// The inputs of the SensorInsightsDeleteUser operation.
/// </summary>
public sealed record SensorInsightsDeleteUserRequest
{
    /// <summary>
    /// Payload for the delete user request.
    /// </summary>
    public required DtoDeleteUserRequest Deleterequestpayload { get; init; }
}
