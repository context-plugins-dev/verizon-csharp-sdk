namespace Verizon.Requests.Sms;

/// <summary>
/// The inputs of the ListDevicesSmsMessages operation.
/// </summary>
public sealed record ListDevicesSmsMessagesRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Continue the previous query from the URL in Location Header.
    /// </summary>
    public long? Next { get; init; }
}
