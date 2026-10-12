using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementLicensesV3;

/// <summary>
/// The inputs of the RemoveLicensesFromDevices3 operation.
/// </summary>
public sealed record RemoveLicensesFromDevices3Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// License removal.
    /// </summary>
    public required V3LicenseImei Body { get; init; }
}
