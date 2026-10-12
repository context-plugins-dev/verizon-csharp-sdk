using Verizon.Models.Enums;

namespace Verizon.Requests.AccountDevices;

/// <summary>
/// The inputs of the GetAccountDeviceInformation operation.
/// </summary>
public sealed record GetAccountDeviceInformationRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Last seen device identifier.
    /// </summary>
    public string? LastSeenDeviceId { get; init; }

    /// <summary>
    /// Filter to retrieve a specific protocol type used.
    /// </summary>
    public DevicesProtocol Protocol { get; init; } = DevicesProtocol.Lwm2M;
}
