namespace Verizon.Requests.SoftwareManagementLicensesV2;

/// <summary>
/// The inputs of the ListLicensesToRemove2 operation.
/// </summary>
public sealed record ListLicensesToRemove2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Start index to retrieve.
    /// </summary>
    public string? StartIndex { get; init; }
}
