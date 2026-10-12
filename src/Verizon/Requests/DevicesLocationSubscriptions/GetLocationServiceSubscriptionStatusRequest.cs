namespace Verizon.Requests.DevicesLocationSubscriptions;

/// <summary>
/// The inputs of the GetLocationServiceSubscriptionStatus operation.
/// </summary>
public sealed record GetLocationServiceSubscriptionStatusRequest
{
    /// <summary>
    /// Account identifier in "##########-#####".
    /// </summary>
    public required string AccountName { get; init; }
}
