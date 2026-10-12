using System.Collections.Generic;
using Verizon.Models.AnyOf;

namespace Verizon.Requests.AnomalyTriggersV2;

/// <summary>
/// The inputs of the CreateAnomalyDetectionTriggerV2 operation.
/// </summary>
public sealed record CreateAnomalyDetectionTriggerV2Request
{
    /// <summary>
    /// Request to create an anomaly trigger.
    /// </summary>
    public required IReadOnlyList<CreateTriggerRequestOptions> Body { get; init; }
}
