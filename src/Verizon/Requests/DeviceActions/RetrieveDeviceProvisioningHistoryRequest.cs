using Verizon.Models;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the RetrieveDeviceProvisioningHistory operation.
/// </summary>
public sealed record RetrieveDeviceProvisioningHistoryRequest
{
    /// <summary>
    /// Device Provisioning History
    /// </summary>
    public required ProvhistoryRequest Body { get; init; }
}
