using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementCallbacksV3;

/// <summary>
/// The inputs of the RegisterCallback5 operation.
/// </summary>
public sealed record RegisterCallback5Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Callback URL registration.
    /// </summary>
    public required FotaV3CallbackRegistrationRequest Body { get; init; }
}
