using Verizon.Models;

namespace Verizon.Requests.Targets;

/// <summary>
/// The inputs of the QueryTarget operation.
/// </summary>
public sealed record QueryTargetOperationRequest
{
    /// <summary>
    /// Search for targets by property values.
    /// </summary>
    public required QueryTargetRequest Body { get; init; }
}
