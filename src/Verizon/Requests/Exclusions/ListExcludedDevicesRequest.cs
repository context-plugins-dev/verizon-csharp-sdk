namespace Verizon.Requests.Exclusions;

/// <summary>
/// The inputs of the ListExcludedDevices operation.
/// </summary>
public sealed record ListExcludedDevicesRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Zero-based number of the first record to return.
    /// </summary>
    public required string StartIndex { get; init; }
}
