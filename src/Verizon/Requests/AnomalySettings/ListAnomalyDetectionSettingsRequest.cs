namespace Verizon.Requests.AnomalySettings;

/// <summary>
/// The inputs of the ListAnomalyDetectionSettings operation.
/// </summary>
public sealed record ListAnomalyDetectionSettingsRequest
{
    /// <summary>
    /// The name of the subscribed account.
    /// </summary>
    public required string AccountName { get; init; }
}
