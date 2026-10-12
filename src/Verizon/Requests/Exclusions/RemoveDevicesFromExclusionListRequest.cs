namespace Verizon.Requests.Exclusions;

/// <summary>
/// The inputs of the RemoveDevicesFromExclusionList operation.
/// </summary>
public sealed record RemoveDevicesFromExclusionListRequest
{
    /// <summary>
    /// The numeric name of the account.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// A list of the device IDs to remove from the exclusion list.
    /// </summary>
    public required string DeviceList { get; init; }
}
