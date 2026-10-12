using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ChangeDevicesServicePlan operation.
/// </summary>
public sealed record ChangeDevicesServicePlanRequest
{
    /// <summary>
    /// Request to change device service plan.
    /// </summary>
    public required ServicePlanUpdateRequest Body { get; init; }
}
