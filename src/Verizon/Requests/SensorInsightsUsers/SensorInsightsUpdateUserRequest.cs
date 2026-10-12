using Verizon.Models;

namespace Verizon.Requests.SensorInsightsUsers;

/// <summary>
/// The inputs of the SensorInsightsUpdateUserRequest operation.
/// </summary>
public sealed record SensorInsightsUpdateUserRequest
{
    /// <summary>
    /// Partially update a user profile
    /// </summary>
    public required DtoUpdateUserRequest Body { get; init; }
}
