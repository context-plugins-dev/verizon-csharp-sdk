using Verizon.Models;

namespace Verizon.Requests.ThingSpaceQualityOfServiceApiActions;

/// <summary>
/// The inputs of the CreateAThingSpaceQualityOfServiceApiSubscription operation.
/// </summary>
public sealed record CreateAThingSpaceQualityOfServiceApiSubscriptionRequest
{
    /// <summary>
    /// The request details to create a ThingSpace Quality of Service API subscription.
    /// </summary>
    public required SubscribeRequest Body { get; init; }
}
