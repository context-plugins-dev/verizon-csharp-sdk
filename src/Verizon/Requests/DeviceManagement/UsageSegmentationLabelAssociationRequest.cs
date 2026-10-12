using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UsageSegmentationLabelAssociation operation.
/// </summary>
public sealed record UsageSegmentationLabelAssociationRequest
{
    /// <summary>
    /// Request to associate a label to a device.
    /// </summary>
    public required AssociateLabelRequest Body { get; init; }
}
