using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the DeviceUploadStatus operation.
/// </summary>
public sealed record DeviceUploadStatusRequest
{
    /// <summary>
    /// The request body identifies the device and reporting period that you want included in the report.
    /// </summary>
    public required CheckOrderStatusRequest Body { get; init; }
}
