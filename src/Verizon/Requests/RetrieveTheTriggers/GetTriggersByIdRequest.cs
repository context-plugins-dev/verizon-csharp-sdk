namespace Verizon.Requests.RetrieveTheTriggers;

/// <summary>
/// The inputs of the GetTriggersById operation.
/// </summary>
public sealed record GetTriggersByIdRequest
{
    /// <summary>
    /// The ID of a specific trigger
    /// </summary>
    public required string TriggerId { get; init; }
}
