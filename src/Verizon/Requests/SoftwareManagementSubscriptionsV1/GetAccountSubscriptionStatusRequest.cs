namespace Verizon.Requests.SoftwareManagementSubscriptionsV1;

/// <summary>
/// The inputs of the GetAccountSubscriptionStatus operation.
/// </summary>
public sealed record GetAccountSubscriptionStatusRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string Account { get; init; }
}
