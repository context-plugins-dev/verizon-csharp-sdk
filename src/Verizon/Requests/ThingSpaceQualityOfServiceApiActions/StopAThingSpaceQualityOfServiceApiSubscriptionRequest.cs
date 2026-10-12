namespace Verizon.Requests.ThingSpaceQualityOfServiceApiActions;

/// <summary>
/// The inputs of the StopAThingSpaceQualityOfServiceApiSubscription operation.
/// </summary>
public sealed record StopAThingSpaceQualityOfServiceApiSubscriptionRequest
{
    public required string AccountName { get; init; }

    public required string QosSubscriptionId { get; init; }
}
