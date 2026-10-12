using Verizon.Models.Enums;

namespace Verizon.Requests.SoftwareManagementReportsV1;

/// <summary>
/// The inputs of the ListUpgradesForSpecifiedStatus operation.
/// </summary>
public sealed record ListUpgradesForSpecifiedStatusRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// The status of the upgrades that you want to retrieve.
    /// </summary>
    public required UpgradeStatus UpgradeStatus { get; init; }

    /// <summary>
    /// The zero-based number of the first record to return. Set startIndex=0 for the first request. If <c>hasMoreFlag</c>=true in the response, use the <c>lastSeenUpgradeId</c> value from the response as the startIndex in the next request.
    /// </summary>
    public required string StartIndex { get; init; }
}
