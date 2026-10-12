using Verizon.Models;

namespace Verizon.Requests.DeviceGroups;

/// <summary>
/// The inputs of the UpdateDeviceGroup operation.
/// </summary>
public sealed record UpdateDeviceGroupRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Group name.
    /// </summary>
    public required string Gname { get; init; }

    /// <summary>
    /// Request to update device group.
    /// </summary>
    public required DeviceGroupUpdateRequest Body { get; init; }
}
