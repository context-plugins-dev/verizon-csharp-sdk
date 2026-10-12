using Verizon.Models;

namespace Verizon.Requests.SimActions;

/// <summary>
/// The inputs of the SetdeactivateUsingPost operation.
/// </summary>
public sealed record SetdeactivateUsingPostRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ProfileRequest2 Body { get; init; }
}
