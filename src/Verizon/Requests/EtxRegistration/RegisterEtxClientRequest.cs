using System;
using Verizon.Models;

namespace Verizon.Requests.EtxRegistration;

/// <summary>
/// The inputs of the RegisterEtxClient operation.
/// </summary>
public sealed record RegisterEtxClientRequest
{
    /// <summary>
    /// Optional transaction identifier for tracing requests. If not provided, the application will generate one.
    /// </summary>
    public Guid? XTransactionId { get; init; }

    public required ClientRegistrationRequestV2 Body { get; init; }
}
