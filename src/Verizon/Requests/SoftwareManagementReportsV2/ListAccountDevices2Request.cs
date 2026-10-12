namespace Verizon.Requests.SoftwareManagementReportsV2;

/// <summary>
/// The inputs of the ListAccountDevices2 operation.
/// </summary>
public sealed record ListAccountDevices2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }

    /// <summary>
    /// Filter distributionType to get specific type of devices. Values is LWM2M, OMD-DM or HTTP.
    /// </summary>
    public string? DistributionType { get; init; }
}
