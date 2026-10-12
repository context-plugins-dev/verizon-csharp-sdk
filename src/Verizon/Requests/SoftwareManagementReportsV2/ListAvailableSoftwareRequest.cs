namespace Verizon.Requests.SoftwareManagementReportsV2;

/// <summary>
/// The inputs of the ListAvailableSoftware operation.
/// </summary>
public sealed record ListAvailableSoftwareRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Filter distributionType to get specific type of software. Value is LWM2M, OMD-DM or HTTP.
    /// </summary>
    public string? DistributionType { get; init; }
}
