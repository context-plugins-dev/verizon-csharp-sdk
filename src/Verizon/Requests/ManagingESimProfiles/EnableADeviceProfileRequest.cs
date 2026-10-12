using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the EnableADeviceProfile operation.
/// </summary>
public sealed record EnableADeviceProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required DeviceProfileRequest Body { get; init; }
}
