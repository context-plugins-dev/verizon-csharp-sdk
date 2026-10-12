namespace Verizon.Requests.ServerLogging;

/// <summary>
/// The inputs of the GetDeviceCheckInHistory operation.
/// </summary>
public sealed record GetDeviceCheckInHistoryRequest
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
