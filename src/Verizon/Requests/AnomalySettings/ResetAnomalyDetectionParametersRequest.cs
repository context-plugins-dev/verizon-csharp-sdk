namespace Verizon.Requests.AnomalySettings;

/// <summary>
/// The inputs of the ResetAnomalyDetectionParameters operation.
/// </summary>
public sealed record ResetAnomalyDetectionParametersRequest
{
    /// <summary>
    /// The name of the subscribed account.
    /// </summary>
    public required string AccountName { get; init; }
}
