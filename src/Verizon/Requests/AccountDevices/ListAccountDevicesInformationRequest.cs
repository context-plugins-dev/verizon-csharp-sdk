using Verizon.Models;

namespace Verizon.Requests.AccountDevices;

/// <summary>
/// The inputs of the ListAccountDevicesInformation operation.
/// </summary>
public sealed record ListAccountDevicesInformationRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Request device list information.
    /// </summary>
    public required DeviceImei Body { get; init; }
}
