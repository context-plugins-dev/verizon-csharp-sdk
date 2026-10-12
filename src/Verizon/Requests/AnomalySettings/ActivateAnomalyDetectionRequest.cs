using Verizon.Models;

namespace Verizon.Requests.AnomalySettings;

/// <summary>
/// The inputs of the ActivateAnomalyDetection operation.
/// </summary>
public sealed record ActivateAnomalyDetectionRequest
{
    /// <summary>
    /// Request to activate anomaly detection.
    /// </summary>
    public required AnomalyDetectionRequest Body { get; init; }
}
