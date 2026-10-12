using Verizon.Models;

namespace Verizon.Requests.CloudConnectorSubscriptions;

/// <summary>
/// The inputs of the QuerySubscription operation.
/// </summary>
public sealed record QuerySubscriptionOperationRequest
{
    /// <summary>
    /// The request body specifies fields and values to match.
    /// </summary>
    public required QuerySubscriptionRequest Body { get; init; }
}
