namespace Verizon.Requests.ConnectivityCallbacks;

/// <summary>
/// The inputs of the DeregisterCallback operation.
/// </summary>
public sealed record DeregisterCallbackRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Service name.
    /// </summary>
    public required string Sname { get; init; }
}
