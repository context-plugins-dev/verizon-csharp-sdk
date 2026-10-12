namespace Verizon.Requests.DeviceServiceManagement;

/// <summary>
/// The inputs of the GetDeviceHyperPreciseStatus operation.
/// </summary>
public sealed record GetDeviceHyperPreciseStatusRequest
{
    /// <summary>
    /// The International Mobile Equipment Identifier of the device.
    /// </summary>
    public required string Imei { get; init; }

    /// <summary>
    /// The numeric name of the account and must include leading zeroes.
    /// </summary>
    public required string AccountNumber { get; init; }
}
