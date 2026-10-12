namespace Verizon.Requests.DeviceGroups;

/// <summary>
/// The inputs of the GetDeviceGroupInformation operation.
/// </summary>
public sealed record GetDeviceGroupInformationRequest
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
    /// Continue the previous query from the pageUrl pagetoken.
    /// </summary>
    public long? Next { get; init; }
}
