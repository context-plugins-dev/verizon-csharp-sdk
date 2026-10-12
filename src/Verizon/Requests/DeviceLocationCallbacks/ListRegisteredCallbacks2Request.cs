namespace Verizon.Requests.DeviceLocationCallbacks;

/// <summary>
/// The inputs of the ListRegisteredCallbacks2 operation.
/// </summary>
public sealed record ListRegisteredCallbacks2Request
{
    /// <summary>
    /// Account number.
    /// </summary>
    public required string AccountName { get; init; }
}
