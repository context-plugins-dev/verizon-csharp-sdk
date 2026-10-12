using Verizon.Models.AnyOf;

namespace Verizon.Requests.UpdatePricePlanTriggers;

/// <summary>
/// The inputs of the UpdateTriggerRules operation.
/// </summary>
public sealed record UpdateTriggerRulesRequest
{
    /// <summary>
    /// Update a trigger
    /// </summary>
    public required V2TriggersRequest1 Body { get; init; }
}
