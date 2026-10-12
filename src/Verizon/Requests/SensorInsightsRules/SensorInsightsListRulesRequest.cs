using Verizon.Models;

namespace Verizon.Requests.SensorInsightsRules;

/// <summary>
/// The inputs of the SensorInsightsListRulesRequest operation.
/// </summary>
public sealed record SensorInsightsListRulesRequest
{
    /// <summary>
    /// Retrieve a rule
    /// </summary>
    public required DtoListRulesRequest Body { get; init; }
}
