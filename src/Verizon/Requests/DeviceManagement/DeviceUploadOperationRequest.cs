using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the DeviceUpload operation.
/// </summary>
public sealed record DeviceUploadOperationRequest
{
    /// <summary>
    /// Device Upload Query
    /// </summary>
    public required DeviceUploadRequest Body { get; init; }
}
