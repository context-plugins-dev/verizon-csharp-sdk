using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the ServicePlanList operation.
/// </summary>
public sealed record ServicePlanListRequest
{
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9]{3,32}$")]
    public required string AccountName { get; init; }
}
