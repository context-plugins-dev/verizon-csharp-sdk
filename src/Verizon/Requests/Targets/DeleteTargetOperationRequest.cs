using Verizon.Models;

namespace Verizon.Requests.Targets;

/// <summary>
/// The inputs of the DeleteTarget operation.
/// </summary>
public sealed record DeleteTargetOperationRequest
{
    /// <summary>
    /// The request body identifies the target to delete.
    /// </summary>
    public required DeleteTargetRequest Body { get; init; }
}
