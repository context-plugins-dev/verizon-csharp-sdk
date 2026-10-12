using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Accurary, currently only 0-coarse supported.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccuracyMode>))]
public sealed record AccuracyMode : OpenStringEnum<AccuracyMode>
{
    private AccuracyMode(string value) : base(value)
    {
    }

    public static readonly AccuracyMode _0 = new("0");

    public TResult Match<TResult>(Func<TResult> on_0, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else otherwise(Value);
    }
}
