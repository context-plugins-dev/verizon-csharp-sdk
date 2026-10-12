using Verizon.Models;

namespace Verizon.Requests.UpdateTriggers;

/// <summary>
/// The inputs of the UpdateAllAvailableTriggers operation.
/// </summary>
public sealed record UpdateAllAvailableTriggersRequest
{
    /// <summary>
    /// Update the triggers
    /// </summary>
    public RequestTrigger? Body { get; init; }
}
