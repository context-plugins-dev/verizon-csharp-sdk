using Verizon.Models;

namespace Verizon.Requests.DeviceSmsMessaging;

/// <summary>
/// The inputs of the SendAnSmsMessage operation.
/// </summary>
public sealed record SendAnSmsMessageRequest
{
    /// <summary>
    /// SMS message to an indiividual device.
    /// </summary>
    public required GiosmsSendRequest Body { get; init; }
}
