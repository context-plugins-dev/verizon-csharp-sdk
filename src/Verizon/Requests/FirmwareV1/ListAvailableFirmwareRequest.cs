namespace Verizon.Requests.FirmwareV1;

/// <summary>
/// The inputs of the ListAvailableFirmware operation.
/// </summary>
public sealed record ListAvailableFirmwareRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }
}
