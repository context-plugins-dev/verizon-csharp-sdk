using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ListDevicesInformation operation.
/// </summary>
public sealed record ListDevicesInformationRequest
{
    /// <summary>
    /// Device information query.
    /// </summary>
    public required AccountDeviceListRequest Body { get; init; }
}
