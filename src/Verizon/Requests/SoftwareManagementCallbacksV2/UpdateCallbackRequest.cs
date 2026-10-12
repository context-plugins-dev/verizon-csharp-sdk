namespace Verizon.Requests.SoftwareManagementCallbacksV2;

/// <summary>
/// The inputs of the UpdateCallback operation.
/// </summary>
public sealed record UpdateCallbackRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
