using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.AccountSubscriptions;

/// <summary>
/// The inputs of the ListAccountSubscriptions operation.
/// </summary>
public sealed record ListAccountSubscriptionsRequest
{
    /// <summary>
    /// Transaction Id.
    /// </summary>
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]-[0-9]{3,32}$")]
    public string? XRequestId { get; init; }

    /// <summary>
    /// Request for account subscription.
    /// </summary>
    public required SecuritySubscriptionRequest Body { get; init; }
}
