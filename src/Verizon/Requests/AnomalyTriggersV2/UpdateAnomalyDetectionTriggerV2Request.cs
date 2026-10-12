using System.Collections.Generic;
using Verizon.Models.AnyOf;

namespace Verizon.Requests.AnomalyTriggersV2;

/// <summary>
/// The inputs of the UpdateAnomalyDetectionTriggerV2 operation.
/// </summary>
public sealed record UpdateAnomalyDetectionTriggerV2Request
{
    /// <summary>
    /// Request to update existing trigger.
    /// </summary>
    public required IReadOnlyList<UpdateTriggerRequestOptions> Body { get; init; }
}
