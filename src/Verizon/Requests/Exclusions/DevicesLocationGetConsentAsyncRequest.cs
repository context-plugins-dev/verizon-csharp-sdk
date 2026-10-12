namespace Verizon.Requests.Exclusions;

/// <summary>
/// The inputs of the DevicesLocationGetConsentAsync operation.
/// </summary>
public sealed record DevicesLocationGetConsentAsyncRequest
{
    /// <summary>
    /// The numeric name of the account.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// The IMEI of the device being queried
    /// </summary>
    public string? DeviceId { get; init; }
}
