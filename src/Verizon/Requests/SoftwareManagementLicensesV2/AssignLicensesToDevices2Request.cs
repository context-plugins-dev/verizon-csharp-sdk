namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the AssignLicensesToDevices2 operation.
/// </summary>
public sealed record AssignLicensesToDevices2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
