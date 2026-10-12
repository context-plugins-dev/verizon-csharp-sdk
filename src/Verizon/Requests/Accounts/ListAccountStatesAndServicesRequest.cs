namespace Verizon.Requests.Accounts;

/// <summary>
/// The inputs of the ListAccountStatesAndServices operation.
/// </summary>
public sealed record ListAccountStatesAndServicesRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
