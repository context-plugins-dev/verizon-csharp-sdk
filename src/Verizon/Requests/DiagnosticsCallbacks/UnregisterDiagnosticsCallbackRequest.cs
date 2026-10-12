namespace Verizon.Requests.DiagnosticsCallbacks;

/// <summary>
/// The inputs of the UnregisterDiagnosticsCallback operation.
/// </summary>
public sealed record UnregisterDiagnosticsCallbackRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Service name for callback notification.
    /// </summary>
    public required string ServiceName { get; init; }
}
