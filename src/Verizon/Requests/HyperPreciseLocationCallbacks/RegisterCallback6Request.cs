using Verizon.Models;

namespace Verizon.Requests.HyperPreciseLocationCallbacks;

/// <summary>
/// The inputs of the RegisterCallback6 operation.
/// </summary>
public sealed record RegisterCallback6Request
{
    /// <summary>
    /// A unique identifier for an account.
    /// </summary>
    public required string AccountNumber { get; init; }

    public required HyperPreciseLocationCallback Body { get; init; }
}
