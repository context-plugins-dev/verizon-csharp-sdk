using Verizon.Models;

namespace Verizon.Requests.ConnectivityCallbacks;

/// <summary>
/// The inputs of the RegisterCallback operation.
/// </summary>
public sealed record RegisterCallbackOperationRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Request to register a callback.
    /// </summary>
    public required RegisterCallbackRequest Body { get; init; }
}
