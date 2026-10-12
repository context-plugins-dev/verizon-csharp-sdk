using Verizon.Models;

namespace Verizon.Requests.Exclusions;

/// <summary>
/// The inputs of the DevicesLocationUpdateConsent operation.
/// </summary>
public sealed record DevicesLocationUpdateConsentRequest
{
    /// <summary>
    /// Account details to update a consent record.
    /// </summary>
    public AccountConsentUpdate? Body { get; init; }
}
