namespace Verizon.Requests.ConnectivityCallbacks;

/// <summary>
/// The inputs of the ListRegisteredCallbacks operation.
/// </summary>
public sealed record ListRegisteredCallbacksRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
