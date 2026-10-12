using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.EtxAppConfiguration;

/// <summary>
/// The inputs of the GetConfigurationList operation.
/// </summary>
public sealed record GetConfigurationListRequest
{
    /// <summary>
    /// The vendor's identifier
    /// </summary>
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }
}
