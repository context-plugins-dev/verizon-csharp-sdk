using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the SearchSensorReadings operation.
/// </summary>
public sealed record SearchSensorReadingsRequest
{
    /// <summary>
    /// The name of the sensor.
    /// </summary>
    public required string Fieldname { get; init; }

    /// <summary>
    /// The device identifier and fields to match in the search.
    /// </summary>
    public required SearchSensorHistoryRequest Body { get; init; }
}
