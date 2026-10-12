using Verizon.Models.AnyOf;

namespace Verizon.Requests.CreatePricePlanTriggers;

/// <summary>
/// The inputs of the CreateTriggerRules operation.
/// </summary>
public sealed record CreateTriggerRulesRequest
{
    /// <summary>
    /// Create a trigger
    /// </summary>
    public required V2TriggersRequest Body { get; init; }
}
