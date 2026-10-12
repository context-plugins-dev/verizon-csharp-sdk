using Verizon.Models;

namespace Verizon.Requests.CloudConnectorSubscriptions;

/// <summary>
/// The inputs of the DeleteSubscription operation.
/// </summary>
public sealed record DeleteSubscriptionOperationRequest
{
    /// <summary>
    /// The request body identifies the subscription to delete.
    /// </summary>
    public required DeleteSubscriptionRequest Body { get; init; }
}
