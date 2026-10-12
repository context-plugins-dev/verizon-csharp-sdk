using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementLicensesV1;

/// <summary>
/// The inputs of the RemoveLicensesFromDevices operation.
/// </summary>
public sealed record RemoveLicensesFromDevicesRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// IMEIs of the devices to remove licenses from.
    /// </summary>
    public required V1LicensesAssignedRemovedRequest Body { get; init; }
}
