namespace Verizon.Requests.SoftwareManagementLicensesV1;

/// <summary>
/// The inputs of the ListLicensesToRemove operation.
/// </summary>
public sealed record ListLicensesToRemoveRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// The zero-based number of the first record to return. Set startIndex=0 for the first request. If there are more than 1,000 devices in the response, set startIndex=1000 for the second request, 2000 for the third request, etc.
    /// </summary>
    public required string StartIndex { get; init; }
}
