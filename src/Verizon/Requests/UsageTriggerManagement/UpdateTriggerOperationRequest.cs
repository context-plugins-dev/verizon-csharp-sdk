using Verizon.Models;

namespace Verizon.Requests.UsageTriggerManagement;

/// <summary>
/// The inputs of the UpdateTrigger operation.
/// </summary>
public sealed record UpdateTriggerOperationRequest
{
    /// <summary>
    /// Usage trigger ID
    /// </summary>
    public required string TriggerId { get; init; }

    /// <summary>
    /// New trigger values
    /// </summary>
    public UsageTriggerUpdateRequest? Body { get; init; }
}
