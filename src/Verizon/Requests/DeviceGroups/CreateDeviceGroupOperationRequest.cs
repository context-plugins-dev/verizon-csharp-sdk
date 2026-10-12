using Verizon.Models;

namespace Verizon.Requests.DeviceGroups;

/// <summary>
/// The inputs of the CreateDeviceGroup operation.
/// </summary>
public sealed record CreateDeviceGroupOperationRequest
{
    /// <summary>
    /// A request to create a new device group.
    /// </summary>
    public required CreateDeviceGroupRequest Body { get; init; }
}
