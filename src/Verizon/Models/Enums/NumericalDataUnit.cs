using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Unit of time.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NumericalDataUnit>))]
public sealed record NumericalDataUnit : OpenStringEnum<NumericalDataUnit>
{
    private NumericalDataUnit(string value) : base(value)
    {
    }

    public static readonly NumericalDataUnit Second = new("SECOND");

    public static readonly NumericalDataUnit Minute = new("MINUTE");

    public static readonly NumericalDataUnit Hour = new("HOUR");

    public static readonly NumericalDataUnit Day = new("DAY");

    public TResult Match<TResult>(Func<TResult> onSecond,
        Func<TResult> onMinute,
        Func<TResult> onHour,
        Func<TResult> onDay,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Second => onSecond(),
            _ when this == Minute => onMinute(),
            _ when this == Hour => onHour(),
            _ when this == Day => onDay(),
            _ => otherwise(Value)
        };

    public void Match(Action onSecond, Action onMinute, Action onHour, Action onDay, Action<string> otherwise)
    {
        if (this == Second) onSecond();
        else if (this == Minute) onMinute();
        else if (this == Hour) onHour();
        else if (this == Day) onDay();
        else otherwise(Value);
    }
}
