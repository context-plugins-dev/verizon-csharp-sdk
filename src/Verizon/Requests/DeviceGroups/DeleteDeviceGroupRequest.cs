namespace Verizon.Requests.DeviceGroups;

/// <summary>
/// The inputs of the DeleteDeviceGroup operation.
/// </summary>
public sealed record DeleteDeviceGroupRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Group name.
    /// </summary>
    public required string Gname { get; init; }
}
