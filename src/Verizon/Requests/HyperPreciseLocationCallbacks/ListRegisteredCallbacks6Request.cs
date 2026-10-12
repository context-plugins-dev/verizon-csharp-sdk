namespace Verizon.Requests.HyperPreciseLocationCallbacks;

/// <summary>
/// The inputs of the ListRegisteredCallbacks6 operation.
/// </summary>
public sealed record ListRegisteredCallbacks6Request
{
    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    public required string AccountNumber { get; init; }
}
