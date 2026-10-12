namespace Verizon.Requests.SoftwareManagementSubscriptionsV3;

/// <summary>
/// The inputs of the GetAccountSubscriptionStatus3 operation.
/// </summary>
public sealed record GetAccountSubscriptionStatus3Request
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string Acc { get; init; }
}
