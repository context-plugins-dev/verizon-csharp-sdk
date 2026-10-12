using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.EtxAppConfiguration;

/// <summary>
/// The inputs of the CreateConfiguration operation.
/// </summary>
public sealed record CreateConfigurationRequest
{
    /// <summary>
    /// The vendor's identifier
    /// </summary>
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    public required GeoFenceConfigurationRequest Body { get; init; }
}
