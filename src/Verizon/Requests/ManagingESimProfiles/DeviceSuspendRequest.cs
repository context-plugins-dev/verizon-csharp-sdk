using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the DeviceSuspend operation.
/// </summary>
public sealed record DeviceSuspendRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GioProfileRequest Body { get; init; }
}
