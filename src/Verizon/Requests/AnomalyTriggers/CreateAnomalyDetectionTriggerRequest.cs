using Verizon.Models;

namespace Verizon.Requests.AnomalyTriggers;

/// <summary>
/// The inputs of the CreateAnomalyDetectionTrigger operation.
/// </summary>
public sealed record CreateAnomalyDetectionTriggerRequest
{
    /// <summary>
    /// Create Trigger Request
    /// </summary>
    public required CreateTriggerRequest Body { get; init; }
}
