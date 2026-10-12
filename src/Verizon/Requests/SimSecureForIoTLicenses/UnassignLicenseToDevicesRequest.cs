using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.SimSecureForIoTLicenses;

/// <summary>
/// The inputs of the UnassignLicenseToDevices operation.
/// </summary>
public sealed record UnassignLicenseToDevicesRequest
{
    /// <summary>
    /// Transaction Id.
    /// </summary>
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]-[0-9]{3,32}$")]
    public required string XRequestId { get; init; }
}
