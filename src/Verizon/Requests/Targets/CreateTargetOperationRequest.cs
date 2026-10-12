using Verizon.Models;

namespace Verizon.Requests.Targets;

/// <summary>
/// The inputs of the CreateTarget operation.
/// </summary>
public sealed record CreateTargetOperationRequest
{
    /// <summary>
    /// The request body provides the details of the target that you want to create.
    /// </summary>
    public required CreateTargetRequest Body { get; init; }
}
