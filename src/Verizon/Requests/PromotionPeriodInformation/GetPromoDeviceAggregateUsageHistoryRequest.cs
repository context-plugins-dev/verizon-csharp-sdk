using Verizon.Models;

namespace Verizon.Requests.PromotionPeriodInformation;

/// <summary>
/// The inputs of the GetPromoDeviceAggregateUsageHistory operation.
/// </summary>
public sealed record GetPromoDeviceAggregateUsageHistoryRequest
{
    /// <summary>
    /// Retrieve Aggregate Usage
    /// </summary>
    public required RequestBodyForUsage Body { get; init; }
}
