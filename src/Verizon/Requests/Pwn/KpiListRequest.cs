namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the KpiList operation.
/// </summary>
public sealed record KpiListRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
