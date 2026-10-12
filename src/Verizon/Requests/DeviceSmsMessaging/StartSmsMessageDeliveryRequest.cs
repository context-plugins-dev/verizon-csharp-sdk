using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.DeviceSmsMessaging;

/// <summary>
/// The inputs of the StartSmsMessageDelivery operation.
/// </summary>
public sealed record StartSmsMessageDeliveryRequest
{
    /// <summary>
    /// Numeric account name
    /// </summary>
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9\\-]{3,32}$")]
    public required string AccountName { get; init; }
}
