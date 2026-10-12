using Verizon.Models;

namespace Verizon.Requests.DevicesLocations;

/// <summary>
/// The inputs of the ListDevicesLocationsSynchronous operation.
/// </summary>
public sealed record ListDevicesLocationsSynchronousRequest
{
    /// <summary>
    /// Request to obtain location of devices.
    /// </summary>
    public required LocationRequest Body { get; init; }
}
