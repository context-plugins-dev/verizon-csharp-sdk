namespace Verizon.Requests.SoftwareManagementSubscriptionsV2;

/// <summary>
/// The inputs of the GetAccountSubscriptionStatus2 operation.
/// </summary>
public sealed record GetAccountSubscriptionStatus2Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Account { get; init; }
}
