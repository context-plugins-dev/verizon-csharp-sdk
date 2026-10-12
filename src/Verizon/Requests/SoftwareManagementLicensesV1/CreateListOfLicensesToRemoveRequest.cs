using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementLicensesV1;

/// <summary>
/// The inputs of the CreateListOfLicensesToRemove operation.
/// </summary>
public sealed record CreateListOfLicensesToRemoveRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Cancellation candidate device list.
    /// </summary>
    public required V1ListOfLicensesToRemoveRequest Body { get; init; }
}
