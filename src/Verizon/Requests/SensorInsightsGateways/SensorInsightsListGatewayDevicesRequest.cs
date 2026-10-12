using Verizon.Models;

namespace Verizon.Requests.SensorInsightsGateways;

/// <summary>
/// The inputs of the SensorInsightsListGatewayDevicesRequest operation.
/// </summary>
public sealed record SensorInsightsListGatewayDevicesRequest
{
    /// <summary>
    /// Get gateway information
    /// </summary>
    public required DtoListDevicesRequest Body { get; init; }
}
