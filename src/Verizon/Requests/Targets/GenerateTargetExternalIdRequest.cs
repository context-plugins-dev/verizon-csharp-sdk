using Verizon.Models;

namespace Verizon.Requests.Targets;

/// <summary>
/// The inputs of the GenerateTargetExternalId operation.
/// </summary>
public sealed record GenerateTargetExternalIdRequest
{
    /// <summary>
    /// The request body only contains the authenticating account.
    /// </summary>
    public required GenerateExternalIdRequest Body { get; init; }
}
