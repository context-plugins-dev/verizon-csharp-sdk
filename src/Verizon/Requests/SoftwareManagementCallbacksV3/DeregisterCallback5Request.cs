namespace Verizon.Requests.SoftwareManagementCallbacksV3;

/// <summary>
/// The inputs of the DeregisterCallback5 operation.
/// </summary>
public sealed record DeregisterCallback5Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }
}
