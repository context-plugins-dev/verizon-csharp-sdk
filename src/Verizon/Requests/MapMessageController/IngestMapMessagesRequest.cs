using System.ComponentModel.DataAnnotations;
using Verizon.Models;
using Verizon.Models.Enums;

namespace Verizon.Requests.MapMessageController;

/// <summary>
/// The inputs of the IngestMapMessages operation.
/// </summary>
public sealed record IngestMapMessagesRequest
{
    /// <summary>
    /// The VendorID set during the Vendor registration call.
    /// </summary>
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    /// <summary>
    /// Select which V2X messaging standard will be used for the message generation. The following options are supported:
    /// - "etsi": The message will be generated using the ETSI (European) standard (e.g. MAPEM).
    /// - "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. MAP).
    /// - if not sent while POST, defaults to "sae"
    /// </summary>
    public EtxMessageStandardEnum MapDataMessageStandard { get; init; } = EtxMessageStandardEnum.Sae;

    /// <summary>
    /// UPER/ASN.1 J2735/ETSI base64 encoded MapData message or JSON representation of the MapData message.
    /// </summary>
    public required EtxMapDataIngestRequest Body { get; init; }
}
