using Verizon.Models;

namespace Verizon.Requests.AnomalyTriggers;

/// <summary>
/// The inputs of the UpdateAnomalyDetectionTrigger operation.
/// </summary>
public sealed record UpdateAnomalyDetectionTriggerRequest
{
    /// <summary>
    /// Update Trigger Request
    /// </summary>
    public required UpdateTriggerRequest Body { get; init; }
}
