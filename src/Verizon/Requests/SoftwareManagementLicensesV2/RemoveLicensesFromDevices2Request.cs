namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the RemoveLicensesFromDevices2 operation.
/// </summary>
public sealed record RemoveLicensesFromDevices2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
