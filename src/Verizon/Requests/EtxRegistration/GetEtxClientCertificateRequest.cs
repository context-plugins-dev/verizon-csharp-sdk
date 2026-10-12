using System;
using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the GetEtxClientCertificate operation.
/// </summary>
public sealed record GetEtxClientCertificateRequest
{
    /// <summary>
    /// One of the following IDs is required- DeviceID, IMEI, ICCID, IMSI. If more than one ID is provided, the API will return the certificate for the first ID found. The IDs are evaluated in the following order: DeviceID, IMEI, ICCID, IMSI. If the first provided ID is not found, the API will return an error.
    /// </summary>
    public required EtxClientIdLookup Id { get; init; }

    /// <summary>
    /// The VendorID set during the Vendor registration call.
    /// </summary>
    [MaxLength(64)]
    [RegularExpression("^[a-zA-Z0-9]+$")]
    public required string VendorId { get; init; }

    /// <summary>
    /// Optional transaction identifier for tracing requests. If not provided, the application will generate one.
    /// </summary>
    public Guid? XTransactionId { get; init; }
}
