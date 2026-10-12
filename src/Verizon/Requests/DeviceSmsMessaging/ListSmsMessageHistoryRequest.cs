using Verizon.Models;

namespace Verizon.Requests.DeviceSmsMessaging;

/// <summary>
/// The inputs of the ListSmsMessageHistory operation.
/// </summary>
public sealed record ListSmsMessageHistoryRequest
{
    /// <summary>
    /// Device Query
    /// </summary>
    public required SmsEventHistoryRequest Body { get; init; }
}
