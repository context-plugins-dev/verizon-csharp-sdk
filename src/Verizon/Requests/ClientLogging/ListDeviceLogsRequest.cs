namespace Verizon.Requests.ClientLogging;

/// <summary>
/// The inputs of the ListDeviceLogs operation.
/// </summary>
public sealed record ListDeviceLogsRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Device IMEI identifier.
    /// </summary>
    public required string DeviceId { get; init; }
}
