using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the ResumeProfile operation.
/// </summary>
public sealed record ResumeProfileRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GioProfileRequest Body { get; init; }
}
