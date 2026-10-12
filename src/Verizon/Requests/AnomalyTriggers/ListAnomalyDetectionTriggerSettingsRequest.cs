namespace Verizon.Requests.AnomalyTriggers;

/// <summary>
/// The inputs of the ListAnomalyDetectionTriggerSettings operation.
/// </summary>
public sealed record ListAnomalyDetectionTriggerSettingsRequest
{
    /// <summary>
    /// trigger ID
    /// </summary>
    public required string TriggerId { get; init; }
}
