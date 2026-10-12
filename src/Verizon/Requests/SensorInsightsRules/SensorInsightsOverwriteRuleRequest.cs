using Verizon.Models;

namespace Verizon.Requests.SensorInsightsRules;

/// <summary>
/// The inputs of the SensorInsightsOverwriteRuleRequest operation.
/// </summary>
public sealed record SensorInsightsOverwriteRuleRequest
{
    /// <summary>
    /// Overwrite a rule
    /// </summary>
    public required DtoOverwriteRuleRequest Body { get; init; }
}
