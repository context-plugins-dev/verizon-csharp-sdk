using Verizon.Models;

namespace Verizon.Requests.HplDeviceManagement;

/// <summary>
/// The inputs of the AddDevicesHyperPrecise operation.
/// </summary>
public sealed record AddDevicesHyperPreciseRequest
{
    /// <summary>
    /// Devices to add to the account.
    /// </summary>
    public required HplAddDevicesRequest Body { get; init; }
}
