namespace Verizon.Requests.Sms;

/// <summary>
/// The inputs of the StartQueuedSmsDelivery operation.
/// </summary>
public sealed record StartQueuedSmsDeliveryRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
