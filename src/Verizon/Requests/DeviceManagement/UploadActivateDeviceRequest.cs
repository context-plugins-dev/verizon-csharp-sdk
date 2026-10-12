using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UploadActivateDevice operation.
/// </summary>
public sealed record UploadActivateDeviceRequest
{
    /// <summary>
    /// Request to Upload and Activate device.
    /// </summary>
    public required UploadsActivatesDeviceRequest Body { get; init; }
}
