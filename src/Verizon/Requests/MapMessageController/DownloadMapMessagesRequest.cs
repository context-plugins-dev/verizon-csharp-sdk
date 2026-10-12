using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.MapMessageController;

/// <summary>
/// The inputs of the DownloadMapMessages operation.
/// </summary>
public sealed record DownloadMapMessagesRequest
{
    /// <summary>
    /// GeoJSON Polygon defining the area to retrieve MAP messages for.
    /// </summary>
    public required GeofencePolygon Geofence { get; init; }

    /// <summary>
    /// The VendorID set during the Vendor registration call.
    /// </summary>
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }
}
