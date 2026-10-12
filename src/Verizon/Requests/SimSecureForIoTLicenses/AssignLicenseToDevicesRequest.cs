using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.SimSecureForIoTLicenses;

/// <summary>
/// The inputs of the AssignLicenseToDevices operation.
/// </summary>
public sealed record AssignLicenseToDevicesRequest
{
    /// <summary>
    /// Transaction Id.
    /// </summary>
    [StringLength(32, MinimumLength = 3)]
    [RegularExpression("^[0-9]-[0-9]{3,32}$")]
    public string? XRequestId { get; init; }

    /// <summary>
    /// Request to assign license to devices.
    /// </summary>
    public required AssignLicenseRequest Body { get; init; }
}
