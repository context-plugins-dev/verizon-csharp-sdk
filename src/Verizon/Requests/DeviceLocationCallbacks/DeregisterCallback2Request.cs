using Verizon.Models.Enums;

namespace Verizon.Requests.DeviceLocationCallbacks;

/// <summary>
/// The inputs of the DeregisterCallback2 operation.
/// </summary>
public sealed record DeregisterCallback2Request
{
    /// <summary>
    /// Account number.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Callback service name.
    /// </summary>
    public required CallbackServiceName Service { get; init; }
}
