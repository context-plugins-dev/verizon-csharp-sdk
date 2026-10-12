using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Specifies how far the event is relevant to.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AwarenessDistance>))]
public sealed record AwarenessDistance : OpenStringEnum<AwarenessDistance>
{
    private AwarenessDistance(string value) : base(value)
    {
    }

    public static readonly AwarenessDistance LessThan50M = new("lessThan50m");

    public static readonly AwarenessDistance LessThan100M = new("lessThan100m");

    public static readonly AwarenessDistance LessThan200M = new("lessThan200m");

    public static readonly AwarenessDistance LessThan500M = new("lessThan500m");

    public static readonly AwarenessDistance LessThan1000M = new("lessThan1000m");

    public static readonly AwarenessDistance LessThan5Km = new("lessThan5km");

    public static readonly AwarenessDistance LessThan10Km = new("lessThan10km");

    public static readonly AwarenessDistance Over10Km = new("over10km");

    public TResult Match<TResult>(Func<TResult> onLessThan50M,
        Func<TResult> onLessThan100M,
        Func<TResult> onLessThan200M,
        Func<TResult> onLessThan500M,
        Func<TResult> onLessThan1000M,
        Func<TResult> onLessThan5Km,
        Func<TResult> onLessThan10Km,
        Func<TResult> onOver10Km,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LessThan50M => onLessThan50M(),
            _ when this == LessThan100M => onLessThan100M(),
            _ when this == LessThan200M => onLessThan200M(),
            _ when this == LessThan500M => onLessThan500M(),
            _ when this == LessThan1000M => onLessThan1000M(),
            _ when this == LessThan5Km => onLessThan5Km(),
            _ when this == LessThan10Km => onLessThan10Km(),
            _ when this == Over10Km => onOver10Km(),
            _ => otherwise(Value)
        };

    public void Match(Action onLessThan50M,
        Action onLessThan100M,
        Action onLessThan200M,
        Action onLessThan500M,
        Action onLessThan1000M,
        Action onLessThan5Km,
        Action onLessThan10Km,
        Action onOver10Km,
        Action<string> otherwise)
    {
        if (this == LessThan50M) onLessThan50M();
        else if (this == LessThan100M) onLessThan100M();
        else if (this == LessThan200M) onLessThan200M();
        else if (this == LessThan500M) onLessThan500M();
        else if (this == LessThan1000M) onLessThan1000M();
        else if (this == LessThan5Km) onLessThan5Km();
        else if (this == LessThan10Km) onLessThan10Km();
        else if (this == Over10Km) onOver10Km();
        else otherwise(Value);
    }
}
