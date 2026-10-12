namespace Verizon.Requests.SoftwareManagementCallbacksV2;

/// <summary>
/// The inputs of the ListRegisteredCallbacks4 operation.
/// </summary>
public sealed record ListRegisteredCallbacks4Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
