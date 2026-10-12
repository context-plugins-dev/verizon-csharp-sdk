using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDeviceProfile;

/// <summary>
/// The inputs of the QueryAProfile operation.
/// </summary>
public sealed record QueryAProfileRequest
{
    /// <summary>
    /// body
    /// </summary>
    public required ResourceResourceQuery Body { get; init; }
}
