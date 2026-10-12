using System;
using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the RenewEtxClientCertificate operation.
/// </summary>
public sealed record RenewEtxClientCertificateRequest
{
    public required Guid DeviceId { get; init; }

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

    public object? Body { get; init; }
}
