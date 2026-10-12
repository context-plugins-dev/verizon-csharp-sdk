using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.DeviceRoleController;

/// <summary>
/// The inputs of the GetAclRulesByVendorId operation.
/// </summary>
public sealed record GetAclRulesByVendorIdRequest
{
    /// <summary>
    /// The user's Vendor ID
    /// </summary>
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }
}
