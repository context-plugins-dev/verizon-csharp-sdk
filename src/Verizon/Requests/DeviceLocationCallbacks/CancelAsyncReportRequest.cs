namespace Verizon.Requests.DeviceLocationCallbacks;

/// <summary>
/// The inputs of the CancelAsyncReport operation.
/// </summary>
public sealed record CancelAsyncReportRequest
{
    /// <summary>
    /// The <c>transactionId</c> value.
    /// </summary>
    public required string Txid { get; init; }

    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }
}
