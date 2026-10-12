namespace Verizon.Requests.AccountRequests;

/// <summary>
/// The inputs of the GetCurrentAsynchronousRequestStatus operation.
/// </summary>
public sealed record GetCurrentAsynchronousRequestStatusRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// UUID from synchronous response.
    /// </summary>
    public required string RequestId { get; init; }
}
