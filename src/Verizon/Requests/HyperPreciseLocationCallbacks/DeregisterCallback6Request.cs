namespace Verizon.Requests.HyperPreciseLocationCallbacks;

/// <summary>
/// The inputs of the DeregisterCallback6 operation.
/// </summary>
public sealed record DeregisterCallback6Request
{
    /// <summary>
    /// The numeric ID of the account and must include leading zeroes. This value is indentical to <c>accountName</c>.
    /// </summary>
    public required string AccountNumber { get; init; }

    /// <summary>
    /// The name of the callback service that will be deleted.
    /// </summary>
    public required string Service { get; init; }
}
