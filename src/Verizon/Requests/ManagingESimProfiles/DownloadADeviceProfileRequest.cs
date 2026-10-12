using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the DownloadADeviceProfile operation.
/// </summary>
public sealed record DownloadADeviceProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required DeviceProfileRequest Body { get; init; }
}
