using Verizon.Models;

namespace Verizon.Requests.GbiDeviceActions5;

/// <summary>
/// The inputs of the BusinessInternetlistDeviceInformation operation.
/// </summary>
public sealed record BusinessInternetlistDeviceInformationRequest
{
    /// <summary>
    /// Device Profile Query
    /// </summary>
    public required GbideviceId5 Body { get; init; }
}
