using Verizon.Models;

namespace Verizon.Requests.SensorInsightsUsers;

/// <summary>
/// The inputs of the SensorInsightsCreateUserRequest operation.
/// </summary>
public sealed record SensorInsightsCreateUserRequest
{
    /// <summary>
    /// Create a user profile
    /// </summary>
    public required DtoCreateUserRequest Body { get; init; }
}
