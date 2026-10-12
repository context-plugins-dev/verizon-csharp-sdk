namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the CreateListOfLicensesToRemove2 operation.
/// </summary>
public sealed record CreateListOfLicensesToRemove2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
