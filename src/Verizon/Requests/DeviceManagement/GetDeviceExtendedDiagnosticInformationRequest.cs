using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the GetDeviceExtendedDiagnosticInformation operation.
/// </summary>
public sealed record GetDeviceExtendedDiagnosticInformationRequest
{
    /// <summary>
    /// Request to query extended diagnostics information for a device.
    /// </summary>
    public required DeviceExtendedDiagnosticsRequest Body { get; init; }
}
