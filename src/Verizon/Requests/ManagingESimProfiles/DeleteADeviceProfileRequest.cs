using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the DeleteADeviceProfile operation.
/// </summary>
public sealed record DeleteADeviceProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required DeviceProfileRequest Body { get; init; }
}
