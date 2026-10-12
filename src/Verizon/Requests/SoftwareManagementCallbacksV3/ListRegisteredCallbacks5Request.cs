namespace Verizon.Requests.SoftwareManagementCallbacksV3;

/// <summary>
/// The inputs of the ListRegisteredCallbacks5 operation.
/// </summary>
public sealed record ListRegisteredCallbacks5Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }
}
