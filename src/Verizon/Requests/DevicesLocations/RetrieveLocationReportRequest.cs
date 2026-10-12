namespace Verizon.Requests.DevicesLocations;

/// <summary>
/// The inputs of the RetrieveLocationReport operation.
/// </summary>
public sealed record RetrieveLocationReportRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Transaction ID from POST /locationreports response.
    /// </summary>
    public required string Txid { get; init; }

    /// <summary>
    /// Zero-based number of the first record to return.
    /// </summary>
    public required int Startindex { get; init; }
}
