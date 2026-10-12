using Verizon.Models;

namespace Verizon.Requests.GbiDeviceActions5;

/// <summary>
/// The inputs of the BusinessInternetServiceplanchange operation.
/// </summary>
public sealed record BusinessInternetServiceplanchangeRequest
{
    /// <summary>
    /// This endpoint is for use when changing a device's service plan to a 5G BI service plan. The service plan can change for an active device up to four times per month but will require address validation for each change. The service plan cannot be changed for a device while its service is suspended.
    /// </summary>
    public required GbichangeRequest5 Body { get; init; }
}
