using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the DeleteDeviceFromAccount operation.
/// </summary>
public sealed record DeleteDeviceFromAccountRequest
{
    /// <summary>
    /// The request body identifies the device to delete.
    /// </summary>
    public required RemoveDeviceRequest Body { get; init; }
}
