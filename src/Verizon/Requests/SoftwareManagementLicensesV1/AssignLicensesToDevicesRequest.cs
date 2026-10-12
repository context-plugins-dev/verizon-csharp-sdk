using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementLicensesV1;

/// <summary>
/// The inputs of the AssignLicensesToDevices operation.
/// </summary>
public sealed record AssignLicensesToDevicesRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// IMEIs of the devices to assign licenses to.
    /// </summary>
    public required V1LicensesAssignedRemovedRequest Body { get; init; }
}
