using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ListDevicesProvisioningHistory operation.
/// </summary>
public sealed record ListDevicesProvisioningHistoryRequest
{
    /// <summary>
    /// Query to obtain device provisioning history.
    /// </summary>
    public required DeviceProvisioningHistoryListRequest Body { get; init; }
}
