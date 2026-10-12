using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the EnableADeviceProfileForDownload operation.
/// </summary>
public sealed record EnableADeviceProfileForDownloadRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required DeviceProfileRequest Body { get; init; }
}
