namespace Verizon.Requests.ClientLogging;

/// <summary>
/// The inputs of the EnableLoggingForDevices operation.
/// </summary>
public sealed record EnableLoggingForDevicesRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
