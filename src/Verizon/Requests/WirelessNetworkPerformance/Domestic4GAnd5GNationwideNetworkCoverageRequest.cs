using Verizon.Models.AnyOf;

namespace Verizon.Requests.WirelessNetworkPerformance;

/// <summary>
/// The inputs of the Domestic4GAnd5GNationwideNetworkCoverage operation.
/// </summary>
public sealed record Domestic4GAnd5GNationwideNetworkCoverageRequest
{
    /// <summary>
    /// Request for network coverage details.
    /// </summary>
    public required M2MV1IntelligenceWirelessCoverageRequest Body { get; init; }
}
