namespace Verizon.Requests.RetrieveRatePlanList;

/// <summary>
/// The inputs of the GetRatePlanList operation.
/// </summary>
public sealed record GetRatePlanListRequest
{
    /// <summary>
    /// The Enterprise Customer Profile Database ID. This is the same as the accountName value
    /// </summary>
    public required string EcpdId { get; init; }
}
