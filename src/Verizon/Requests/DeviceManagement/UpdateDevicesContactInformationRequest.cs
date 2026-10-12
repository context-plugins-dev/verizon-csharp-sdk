using Verizon.Models;

namespace Verizon.Requests.DeviceManagement;

/// <summary>
/// The inputs of the UpdateDevicesContactInformation operation.
/// </summary>
public sealed record UpdateDevicesContactInformationRequest
{
    /// <summary>
    /// Request to update contact information for devices.
    /// </summary>
    public required ContactInfoUpdateRequest Body { get; init; }
}
