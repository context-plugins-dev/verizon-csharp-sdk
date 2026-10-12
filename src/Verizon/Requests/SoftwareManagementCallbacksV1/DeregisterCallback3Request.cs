using Verizon.Models.Enums;

namespace Verizon.Requests.SoftwareManagementCallbacksV1;

/// <summary>
/// The inputs of the DeregisterCallback3 operation.
/// </summary>
public sealed record DeregisterCallback3Request
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }

    /// <summary>
    /// Callback type. Must be 'Fota' for Software Management Services API.
    /// </summary>
    public required CallbackService Service { get; init; }
}
