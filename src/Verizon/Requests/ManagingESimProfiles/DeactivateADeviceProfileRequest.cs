using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the DeactivateADeviceProfile operation.
/// </summary>
public sealed record DeactivateADeviceProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GioDeactivateDeviceProfileRequest Body { get; init; }
}
