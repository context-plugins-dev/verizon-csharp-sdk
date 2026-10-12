using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.DeviceSmsMessaging;

/// <summary>
/// The inputs of the GetSmsMessages operation.
/// </summary>
public sealed record GetSmsMessagesRequest
{
    /// <summary>
    /// Numeric account name
    /// </summary>
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9\\-]{3,32}$")]
    public required string AccountName { get; init; }

    /// <summary>
    /// Continue the previous query from the pageUrl in Location Header
    /// </summary>
    [StringLength(64, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public string? Next { get; init; }
}
