namespace Verizon.Requests.SoftwareManagementLicensesV1;

/// <summary>
/// The inputs of the DeleteListOfLicensesToRemove operation.
/// </summary>
public sealed record DeleteListOfLicensesToRemoveRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }
}
