namespace Verizon.Requests.DiagnosticsCallbacks;

/// <summary>
/// The inputs of the GetDiagnosticsSubscriptionCallbackInfo operation.
/// </summary>
public sealed record GetDiagnosticsSubscriptionCallbackInfoRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }
}
