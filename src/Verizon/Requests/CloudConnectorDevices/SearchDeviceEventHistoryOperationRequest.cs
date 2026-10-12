using Verizon.Models;

namespace Verizon.Requests.CloudConnectorDevices;

/// <summary>
/// The inputs of the SearchDeviceEventHistory operation.
/// </summary>
public sealed record SearchDeviceEventHistoryOperationRequest
{
    /// <summary>
    /// The device identifier and fields to match in the search.
    /// </summary>
    public required SearchDeviceEventHistoryRequest Body { get; init; }
}
