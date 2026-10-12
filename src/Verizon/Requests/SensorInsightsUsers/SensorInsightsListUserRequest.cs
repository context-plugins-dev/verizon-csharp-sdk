using Verizon.Models;

namespace Verizon.Requests.SensorInsightsUsers;

/// <summary>
/// The inputs of the SensorInsightsListUserRequest operation.
/// </summary>
public sealed record SensorInsightsListUserRequest
{
    /// <summary>
    /// A summary of user profile records on an account
    /// </summary>
    public required DtoListUserRequest Body { get; init; }
}
