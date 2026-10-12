using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsListNetworkExperienceHistoryRequest operation.
/// </summary>
public sealed record SensorInsightsListNetworkExperienceHistoryRequest
{
    /// <summary>
    /// List the network experience
    /// </summary>
    public required DtoListNetworkExperienceHistoryRequest Body { get; init; }
}
