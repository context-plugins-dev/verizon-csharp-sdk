namespace Verizon.Requests.ServicePlans;

/// <summary>
/// The inputs of the ListAccountServicePlans operation.
/// </summary>
public sealed record ListAccountServicePlansRequest
{
    /// <summary>
    /// Account name.
    /// </summary>
    public required string Aname { get; init; }
}
