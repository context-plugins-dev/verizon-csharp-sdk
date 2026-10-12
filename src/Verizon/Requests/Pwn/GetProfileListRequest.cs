namespace Verizon.Requests.Pwn;

/// <summary>
/// The inputs of the GetProfileList operation.
/// </summary>
public sealed record GetProfileListRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
