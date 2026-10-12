using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Location cache mode.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CacheMode>))]
public sealed record CacheMode : OpenStringEnum<CacheMode>
{
    private CacheMode(string value) : base(value)
    {
    }

    public static readonly CacheMode _0 = new("0");

    public static readonly CacheMode _1 = new("1");

    public static readonly CacheMode _2 = new("2");

    public TResult Match<TResult>(Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ => otherwise(Value)
        };

    public void Match(Action on_0, Action on_1, Action on_2, Action<string> otherwise)
    {
        if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else otherwise(Value);
    }
}
