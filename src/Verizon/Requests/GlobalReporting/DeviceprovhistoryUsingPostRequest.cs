using Verizon.Models;

namespace Verizon.Requests.GlobalReporting;

/// <summary>
/// The inputs of the DeviceprovhistoryUsingPost operation.
/// </summary>
public sealed record DeviceprovhistoryUsingPostRequest
{
    /// <summary>
    /// Device Provisioning History
    /// </summary>
    public required ESimProvhistoryRequest Body { get; init; }
}
