namespace Verizon.Requests.SoftwareManagementCallbacksV2;

/// <summary>
/// The inputs of the DeregisterCallback4 operation.
/// </summary>
public sealed record DeregisterCallback4Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
