using System;
using System.ComponentModel.DataAnnotations;
using Verizon.Models;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the GetEtxConnectionUrlMultiMec operation.
/// </summary>
public sealed record GetEtxConnectionUrlMultiMecRequest
{
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

    public required ConnectionRequest Body { get; init; }
}
