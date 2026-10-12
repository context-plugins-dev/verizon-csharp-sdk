using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the ActivateADeviceProfile operation.
/// </summary>
public sealed record ActivateADeviceProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GioProfileRequest Body { get; init; }
}
