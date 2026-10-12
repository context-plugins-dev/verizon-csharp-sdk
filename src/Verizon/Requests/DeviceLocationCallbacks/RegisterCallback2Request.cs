namespace Verizon.Requests.DeviceLocationCallbacks;

/// <summary>
/// The inputs of the RegisterCallback2 operation.
/// </summary>
public sealed record RegisterCallback2Request
{
    /// <summary>
    /// Account number.
    /// </summary>
    public required string AccountName { get; init; }
}
