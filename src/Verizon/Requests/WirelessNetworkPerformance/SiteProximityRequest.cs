using Verizon.Models;

namespace Verizon.Requests.WirelessNetworkPerformance;

/// <summary>
/// The inputs of the SiteProximity operation.
/// </summary>
public sealed record SiteProximityRequest
{
    /// <summary>
    /// Request for cell site proximity.
    /// </summary>
    public required GetNetworkConditionsRequest Body { get; init; }
}
