using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the UpdateDevicesConfigurationValue operation.
/// </summary>
public sealed record UpdateDevicesConfigurationValueRequest
{
    /// <summary>
    /// The request body changes configuration values on a device.
    /// </summary>
    public required ChangeConfigurationRequest Body { get; init; }
}
