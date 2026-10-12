namespace Verizon.Requests.SoftwareManagementCallbacksV2;

/// <summary>
/// The inputs of the RegisterCallback4 operation.
/// </summary>
public sealed record RegisterCallback4Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
