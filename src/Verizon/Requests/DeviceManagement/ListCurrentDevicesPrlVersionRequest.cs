using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ListCurrentDevicesPrlVersion operation.
/// </summary>
public sealed record ListCurrentDevicesPrlVersionRequest
{
    /// <summary>
    /// Request to query device PRL.
    /// </summary>
    public required DevicePrlListRequest Body { get; init; }
}
