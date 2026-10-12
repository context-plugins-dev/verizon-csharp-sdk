using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the UnregisterEtxClients operation.
/// </summary>
public sealed record UnregisterEtxClientsRequest
{
    /// <summary>
    /// The list of device IDs and software service IDs to be unregistered
    /// </summary>
    [MinLength(1)]
    [MaxLength(100)]
    public required IReadOnlyList<Guid> DeviceIDs { get; init; }

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
