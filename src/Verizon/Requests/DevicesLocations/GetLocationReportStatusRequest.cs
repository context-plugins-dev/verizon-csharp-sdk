namespace Verizon.Requests.DevicesLocations;

/// <summary>
/// The inputs of the GetLocationReportStatus operation.
/// </summary>
public sealed record GetLocationReportStatusRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Transaction ID of the report.
    /// </summary>
    public required string Txid { get; init; }
}
