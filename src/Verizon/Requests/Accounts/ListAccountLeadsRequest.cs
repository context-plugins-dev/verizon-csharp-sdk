namespace Verizon.Requests.Accounts;

/// <summary>
/// The inputs of the ListAccountLeads operation.
/// </summary>
public sealed record ListAccountLeadsRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }

    /// <summary>
    /// Continue the previous query from the pageUrl in Location Header.
    /// </summary>
    public long? Next { get; init; }
}
