using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.EtxAppConfiguration;

/// <summary>
/// The inputs of the GetConfiguration operation.
/// </summary>
public sealed record GetConfigurationRequest
{
    /// <summary>
    /// The configuration identifier
    /// </summary>
    [StringLength(36, MinimumLength = 32)]
    [RegularExpression("^[0-9a-fA-F]{8}-?[0-9a-fA-F]{4}-?4[0-9a-fA-F]{3}-?[89abAB][0-9a-fA-F]{3}-?[0-9a-fA-F]{12}$")]
    public required string Id { get; init; }

    /// <summary>
    /// The vendor's identifier
    /// </summary>
    [StringLength(64, MinimumLength = 1)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }
}
