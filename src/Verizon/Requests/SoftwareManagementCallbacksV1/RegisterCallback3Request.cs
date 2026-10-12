using Verizon.Models;

namespace Verizon.Requests.SoftwareManagementCallbacksV1;

/// <summary>
/// The inputs of the RegisterCallback3 operation.
/// </summary>
public sealed record RegisterCallback3Request
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Callback details.
    /// </summary>
    public required FotaV1CallbackRegistrationRequest Body { get; init; }
}
