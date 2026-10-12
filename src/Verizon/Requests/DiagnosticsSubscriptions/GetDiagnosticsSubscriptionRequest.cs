namespace Verizon.Requests.DiagnosticsSubscriptions;

/// <summary>
/// The inputs of the GetDiagnosticsSubscription operation.
/// </summary>
public sealed record GetDiagnosticsSubscriptionRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }
}
