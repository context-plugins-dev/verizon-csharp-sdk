using Verizon.Models;

namespace Verizon.Requests.Sms;

/// <summary>
/// The inputs of the SendSmsToDevice operation.
/// </summary>
public sealed record SendSmsToDeviceRequest
{
    /// <summary>
    /// Request to send SMS.
    /// </summary>
    public required SmsSendRequest Body { get; init; }
}
