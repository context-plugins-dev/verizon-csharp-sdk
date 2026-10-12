namespace Verizon.Requests.DiagnosticsObservations;

/// <summary>
/// The inputs of the StopDiagnosticsObservation operation.
/// </summary>
public sealed record StopDiagnosticsObservationRequest
{
    /// <summary>
    /// The ID value associated with the transaction.
    /// </summary>
    public required string TransactionId { get; init; }

    /// <summary>
    /// The numeric account name.
    /// </summary>
    public required string AccountName { get; init; }
}
