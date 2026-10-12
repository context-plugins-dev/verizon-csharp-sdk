using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the ListDevicesWithImeiIccidMismatch operation.
/// </summary>
public sealed record ListDevicesWithImeiIccidMismatchRequest
{
    /// <summary>
    /// Request to list devices with mismatched IMEIs and ICCIDs.
    /// </summary>
    public required DeviceMismatchListRequest Body { get; init; }
}
