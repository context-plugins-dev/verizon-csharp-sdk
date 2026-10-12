using Verizon.Models;

namespace Verizon.Requests.EUiccDeviceProfileManagement;

/// <summary>
/// The inputs of the EnableLocalProfile operation.
/// </summary>
public sealed record EnableLocalProfileRequest
{
    /// <summary>
    /// Update state
    /// </summary>
    public required ProfileChangeStateRequest Body { get; init; }
}
