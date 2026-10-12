using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The protocol version of the DENM.
/// </summary>
[JsonConverter(typeof(IntEnumConverter<ProtocolVersion>))]
public sealed record ProtocolVersion : OpenIntEnum<ProtocolVersion>
{
    private ProtocolVersion(long value) : base(value)
    {
    }

    /// <summary>
    /// Version 2 — current DENM PDU protocol version
    /// </summary>
    public static readonly ProtocolVersion Value2 = new(2L);

    public TResult Match<TResult>(Func<TResult> onValue2, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value2 => onValue2(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue2, Action<long> otherwise)
    {
        if (this == Value2) onValue2();
        else otherwise(Value);
    }
}
