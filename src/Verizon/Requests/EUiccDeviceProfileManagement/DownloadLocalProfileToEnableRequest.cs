using Verizon.Models;

namespace Verizon.Requests.EUiccDeviceProfileManagement;

/// <summary>
/// The inputs of the DownloadLocalProfileToEnable operation.
/// </summary>
public sealed record DownloadLocalProfileToEnableRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required ProfileChangeStateRequest Body { get; init; }
}
