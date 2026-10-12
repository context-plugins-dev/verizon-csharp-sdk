using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UsageSegmentationLabelDeletion operation.
/// </summary>
public sealed record UsageSegmentationLabelDeletionRequest
{
    /// <summary>
    /// The numeric name of the account.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// A list of the Label IDs to remove from the exclusion list.
    /// </summary>
    public required LabelsList LabelList { get; init; }
}
