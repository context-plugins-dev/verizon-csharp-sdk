using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the FindDeviceByPropertyValues operation.
/// </summary>
public sealed record FindDeviceByPropertyValuesRequest
{
    /// <summary>
    /// The request body specifies fields and values to match.
    /// </summary>
    public required QuerySubscriptionRequest Body { get; init; }
}
