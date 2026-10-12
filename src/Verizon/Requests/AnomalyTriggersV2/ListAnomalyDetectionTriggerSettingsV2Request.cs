namespace Verizon.Requests.AnomalyTriggersV2;

/// <summary>
/// The inputs of the ListAnomalyDetectionTriggerSettingsV2 operation.
/// </summary>
public sealed record ListAnomalyDetectionTriggerSettingsV2Request
{
    /// <summary>
    /// The trigger ID of a specific trigger.
    /// </summary>
    public required string TriggerId { get; init; }
}
