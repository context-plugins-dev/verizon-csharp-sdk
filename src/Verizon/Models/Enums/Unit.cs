using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Unit>))]
public sealed record Unit : OpenStringEnum<Unit>
{
    private Unit(string value) : base(value)
    {
    }

    public static readonly Unit Minutes = new("minutes");

    public static readonly Unit Hours = new("hours");

    public TResult Match<TResult>(Func<TResult> onMinutes, Func<TResult> onHours, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Minutes => onMinutes(),
            _ when this == Hours => onHours(),
            _ => otherwise(Value)
        };

    public void Match(Action onMinutes, Action onHours, Action<string> otherwise)
    {
        if (this == Minutes) onMinutes();
        else if (this == Hours) onHours();
        else otherwise(Value);
    }
}
