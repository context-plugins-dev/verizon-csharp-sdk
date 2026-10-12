using Verizon.Models;

namespace Verizon.Requests.EUiccDeviceProfileManagement;

/// <summary>
/// The inputs of the DeleteLocalProfile operation.
/// </summary>
public sealed record DeleteLocalProfileRequest
{
    /// <summary>
    /// Update state
    /// </summary>
    public required ProfileChangeStateRequest Body { get; init; }
}
