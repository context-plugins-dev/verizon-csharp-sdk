using Verizon.Models;

namespace Verizon.Requests.EUiccDeviceProfileManagement;

/// <summary>
/// The inputs of the DisableLocalProfile operation.
/// </summary>
public sealed record DisableLocalProfileRequest
{
    /// <summary>
    /// Update state
    /// </summary>
    public required ProfileChangeStateRequest Body { get; init; }
}
