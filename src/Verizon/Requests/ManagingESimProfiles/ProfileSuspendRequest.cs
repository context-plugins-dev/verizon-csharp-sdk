using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the ProfileSuspend operation.
/// </summary>
public sealed record ProfileSuspendRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GioProfileRequest Body { get; init; }
}
