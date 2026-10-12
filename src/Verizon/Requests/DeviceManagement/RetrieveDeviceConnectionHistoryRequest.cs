using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the RetrieveDeviceConnectionHistory operation.
/// </summary>
public sealed record RetrieveDeviceConnectionHistoryRequest
{
    /// <summary>
    /// Query to retrieve device connection history.
    /// </summary>
    public required DeviceConnectionListRequest Body { get; init; }
}
