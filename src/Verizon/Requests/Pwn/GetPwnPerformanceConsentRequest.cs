namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the GetPwnPerformanceConsent operation.
/// </summary>
public sealed record GetPwnPerformanceConsentRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
