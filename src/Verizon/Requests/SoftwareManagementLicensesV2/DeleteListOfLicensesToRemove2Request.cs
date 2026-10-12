namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the DeleteListOfLicensesToRemove2 operation.
/// </summary>
public sealed record DeleteListOfLicensesToRemove2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
