namespace Verizon.Requests.Billing;

/// <summary>
/// The inputs of the ListManagedAccount operation.
/// </summary>
public sealed record ListManagedAccountRequest
{
    /// <summary>
    /// Primary account identifier
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Service name
    /// </summary>
    public required string ServiceName { get; init; }
}
