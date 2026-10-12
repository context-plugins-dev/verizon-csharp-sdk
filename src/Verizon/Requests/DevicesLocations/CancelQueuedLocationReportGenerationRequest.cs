namespace Verizon.Requests.DevicesLocations;

/// <summary>
/// The inputs of the CancelQueuedLocationReportGeneration operation.
/// </summary>
public sealed record CancelQueuedLocationReportGenerationRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Transaction ID of the report to cancel.
    /// </summary>
    public required string Txid { get; init; }
}
