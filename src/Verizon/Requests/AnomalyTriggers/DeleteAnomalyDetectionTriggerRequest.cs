namespace Verizon.Requests.AnomalyTriggers;

/// <summary>
/// The inputs of the DeleteAnomalyDetectionTrigger operation.
/// </summary>
public sealed record DeleteAnomalyDetectionTriggerRequest
{
    /// <summary>
    /// The trigger ID to be deleted
    /// </summary>
    public required string TriggerId { get; init; }
}
