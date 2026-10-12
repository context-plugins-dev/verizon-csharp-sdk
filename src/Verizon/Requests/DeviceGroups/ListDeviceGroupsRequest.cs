namespace Verizon.Requests.DeviceGroups;

/// <summary>
/// The inputs of the ListDeviceGroups operation.
/// </summary>
public sealed record ListDeviceGroupsRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
