using Verizon.Models;

namespace Verizon.Requests.CloudConnectorSubscriptions;

/// <summary>
/// The inputs of the CreateSubscription operation.
/// </summary>
public sealed record CreateSubscriptionOperationRequest
{
    /// <summary>
    /// The request body provides the details of the subscription that you want to create.
    /// </summary>
    public required CreateSubscriptionRequest Body { get; init; }
}
