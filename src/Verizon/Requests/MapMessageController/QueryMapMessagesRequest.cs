using System.ComponentModel.DataAnnotations;
using Verizon.Models.AnyOf;

namespace Verizon.Requests.MapMessageController;

/// <summary>
/// The inputs of the QueryMapMessages operation.
/// </summary>
public sealed record QueryMapMessagesRequest
{
    /// <summary>
    /// The VendorID set during the Vendor registration call.
    /// </summary>
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    public required MapDataQueryRequest Body { get; init; }
}
