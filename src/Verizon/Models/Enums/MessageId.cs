using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of ITIS message (typically 1 for DENM).
/// </summary>
[JsonConverter(typeof(IntEnumConverter<MessageId>))]
public sealed record MessageId : OpenIntEnum<MessageId>
{
    private MessageId(long value) : base(value)
    {
    }

    /// <summary>
    /// Value 1 — identifies the message as a DENM
    /// </summary>
    public static readonly MessageId Value1 = new(1L);

    public TResult Match<TResult>(Func<TResult> onValue1, Func<long, TResult> otherwise) =>
        this switch
        {
            _ when this == Value1 => onValue1(),
            _ => otherwise(Value)
        };

    public void Match(Action onValue1, Action<long> otherwise)
    {
        if (this == Value1) onValue1();
        else otherwise(Value);
    }
}
