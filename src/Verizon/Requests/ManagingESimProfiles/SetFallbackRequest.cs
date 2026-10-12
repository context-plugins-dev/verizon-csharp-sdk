using Verizon.Models;

namespace Verizon.Requests.ManagingESimProfiles;

/// <summary>
/// The inputs of the SetFallback operation.
/// </summary>
public sealed record SetFallbackRequest
{
    /// <summary>
    /// Set the fallback attributes to allow a fallback profile to be activated.
    /// </summary>
    public required FallBack Body { get; init; }
}
