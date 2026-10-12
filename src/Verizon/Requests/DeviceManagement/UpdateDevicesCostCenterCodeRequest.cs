using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UpdateDevicesCostCenterCode operation.
/// </summary>
public sealed record UpdateDevicesCostCenterCodeRequest
{
    /// <summary>
    /// Request to update cost center code value for one or more devices.
    /// </summary>
    public required DeviceCostCenterRequest Body { get; init; }
}
