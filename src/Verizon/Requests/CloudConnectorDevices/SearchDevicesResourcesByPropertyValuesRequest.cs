using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the SearchDevicesResourcesByPropertyValues operation.
/// </summary>
public sealed record SearchDevicesResourcesByPropertyValuesRequest
{
    /// <summary>
    /// The request body specifies fields and values to match.
    /// </summary>
    public required QuerySubscriptionRequest Body { get; init; }
}
