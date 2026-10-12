using Verizon.Models.Enums;

namespace Verizon.Requests.FirmwareV3;

/// <summary>
/// The inputs of the ListAvailableFirmware2 operation.
/// </summary>
public sealed record ListAvailableFirmware2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }

    /// <summary>
    /// Filter to retrieve a specific protocol type used.
    /// </summary>
    public FirmwareProtocol Protocol { get; init; } = FirmwareProtocol.Lwm2M;
}
