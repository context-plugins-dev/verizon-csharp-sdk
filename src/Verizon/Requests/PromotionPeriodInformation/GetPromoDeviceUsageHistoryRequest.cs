using Verizon.Models;

namespace Verizon.Requests.PromotionPeriodInformation;

/// <summary>
/// The inputs of the GetPromoDeviceUsageHistory operation.
/// </summary>
public sealed record GetPromoDeviceUsageHistoryRequest
{
    /// <summary>
    /// Retrieve Aggregate Usage
    /// </summary>
    public required ARequestBodyForUsage Body { get; init; }
}
