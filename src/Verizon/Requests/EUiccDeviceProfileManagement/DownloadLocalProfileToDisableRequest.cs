using Verizon.Models;

namespace Verizon.Requests.EUiccDeviceProfileManagement;

/// <summary>
/// The inputs of the DownloadLocalProfileToDisable operation.
/// </summary>
public sealed record DownloadLocalProfileToDisableRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ProfileChangeStateRequest Body { get; init; }
}
