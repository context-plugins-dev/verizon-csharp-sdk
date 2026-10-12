using Verizon.Models;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the RetrieveTheGlobalDeviceList operation.
/// </summary>
public sealed record RetrieveTheGlobalDeviceListRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GetDeviceListWithProfilesRequest Body { get; init; }
}
