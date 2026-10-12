namespace Verizon.Requests.SoftwareManagementReportsV1;

/// <summary>
/// The inputs of the ListAccountDevices operation.
/// </summary>
public sealed record ListAccountDevicesRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Only return devices with IMEIs larger than this value. Use 0 for the first request. If <c>hasMoreData</c>=true in the response, use the <c>lastSeenDeviceId</c> value from the response as the startIndex in the next request.
    /// </summary>
    public required string StartIndex { get; init; }
}
