using Verizon.Models;

namespace Verizon.Requests.Exclusions;

/// <summary>
/// The inputs of the DevicesLocationGiveConsentAsync operation.
/// </summary>
public sealed record DevicesLocationGiveConsentAsyncRequest
{
    /// <summary>
    /// Account details to create a consent record.
    /// </summary>
    public AccountConsentCreate? Body { get; init; }
}
