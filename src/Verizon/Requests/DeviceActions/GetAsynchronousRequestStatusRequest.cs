using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.DeviceActions;

/// <summary>
/// The inputs of the GetAsynchronousRequestStatus operation.
/// </summary>
public sealed record GetAsynchronousRequestStatusRequest
{
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9\\-]{3,32}$")]
    public required string AccountName { get; init; }

    [StringLength(64, MinimumLength = 3)]
    [RegularExpression("^[A-Za-z0-9\\-]{3,64}$")]
    public required string RequestId { get; init; }
}
