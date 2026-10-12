using Verizon.Models;

namespace Verizon.Requests.SimActions;

/// <summary>
/// The inputs of the SetactivateUsingPost operation.
/// </summary>
public sealed record SetactivateUsingPostRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ESimProfileRequest Body { get; init; }
}
