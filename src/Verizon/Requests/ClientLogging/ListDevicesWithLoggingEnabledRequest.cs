namespace Verizon.Requests.ClientLogging;

/// <summary>
/// The inputs of the ListDevicesWithLoggingEnabled operation.
/// </summary>
public sealed record ListDevicesWithLoggingEnabledRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
