using Verizon.Models;

namespace Verizon.Requests.SimActions;

/// <summary>
/// The inputs of the Newactivatecode operation.
/// </summary>
public sealed record NewactivatecodeRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ESimProfileRequest2 Body { get; init; }
}
