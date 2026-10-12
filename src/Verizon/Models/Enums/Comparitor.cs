using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The boolean of the comparison. <c>gt</c> is Greater Than, <c>lt</c> is Less Than and <c>eq</c> is Equal To
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comparitor>))]
public sealed record Comparitor : OpenStringEnum<Comparitor>
{
    private Comparitor(string value) : base(value)
    {
    }

    public static readonly Comparitor Gt = new("gt");

    public static readonly Comparitor Lt = new("lt");

    public static readonly Comparitor Eq = new("eq");

    public TResult Match<TResult>(Func<TResult> onGt,
        Func<TResult> onLt,
        Func<TResult> onEq,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Gt => onGt(),
            _ when this == Lt => onLt(),
            _ when this == Eq => onEq(),
            _ => otherwise(Value)
        };

    public void Match(Action onGt, Action onLt, Action onEq, Action<string> otherwise)
    {
        if (this == Gt) onGt();
        else if (this == Lt) onLt();
        else if (this == Eq) onEq();
        else otherwise(Value);
    }
}
