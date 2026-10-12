using System;
using Verizon.Models;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the QueryEtxDevices operation.
/// </summary>
public sealed record QueryEtxDevicesRequest
{
    /// <summary>
    /// Optional transaction identifier for tracing requests. If not provided, the application will generate one.
    /// </summary>
    public Guid? XTransactionId { get; init; }

    public required DevicesRequest Body { get; init; }
}
