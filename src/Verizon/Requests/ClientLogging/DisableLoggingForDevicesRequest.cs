namespace Verizon.Requests.ClientLogging;

/// <summary>
/// The inputs of the DisableLoggingForDevices operation.
/// </summary>
public sealed record DisableLoggingForDevicesRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// The list of device IDs.
    /// </summary>
    public required string DeviceIds { get; init; }
}
