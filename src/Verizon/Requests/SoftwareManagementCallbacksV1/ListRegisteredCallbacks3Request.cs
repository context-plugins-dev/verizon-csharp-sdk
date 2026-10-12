namespace Verizon.Requests.SoftwareManagementCallbacksV1;

/// <summary>
/// The inputs of the ListRegisteredCallbacks3 operation.
/// </summary>
public sealed record ListRegisteredCallbacks3Request
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }
}
