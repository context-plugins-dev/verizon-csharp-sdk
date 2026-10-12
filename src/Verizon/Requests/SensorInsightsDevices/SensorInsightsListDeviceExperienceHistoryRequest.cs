using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsListDeviceExperienceHistoryRequest operation.
/// </summary>
public sealed record SensorInsightsListDeviceExperienceHistoryRequest
{
    /// <summary>
    /// List the device experience
    /// </summary>
    public required DtoListDeviceExperienceHistoryRequest Body { get; init; }
}
