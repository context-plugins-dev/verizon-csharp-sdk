namespace Verizon.Requests.UsageTriggerManagement;

/// <summary>
/// The inputs of the DeleteTrigger operation.
/// </summary>
public sealed record DeleteTriggerRequest
{
    /// <summary>
    /// Account name
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Usage trigger ID
    /// </summary>
    public required string TriggerId { get; init; }
}
