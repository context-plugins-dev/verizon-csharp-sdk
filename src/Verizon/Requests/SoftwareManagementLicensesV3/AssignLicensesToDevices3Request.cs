using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementLicensesV3;

/// <summary>
/// The inputs of the AssignLicensesToDevices3 operation.
/// </summary>
public sealed record AssignLicensesToDevices3Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// License assignment.
    /// </summary>
    public required V3LicenseImei Body { get; init; }
}
