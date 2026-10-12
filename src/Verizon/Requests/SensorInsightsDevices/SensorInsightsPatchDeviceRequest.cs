using Verizon.Models;

namespace Verizon.Requests.SensorInsightsDevices;

/// <summary>
/// The inputs of the SensorInsightsPatchDeviceRequest operation.
/// </summary>
public sealed record SensorInsightsPatchDeviceRequest
{
    /// <summary>
    /// Partially update a device's details
    /// </summary>
    public required DtoPatchDeviceRequest Body { get; init; }
}
