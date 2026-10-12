using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The units of the threshold. This can be KB, Kilobits, MB, Megabits, or GB, Gigabits
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ThresholdUnit>))]
public sealed record ThresholdUnit : OpenStringEnum<ThresholdUnit>
{
    private ThresholdUnit(string value) : base(value)
    {
    }

    public static readonly ThresholdUnit Kb = new("KB");

    public static readonly ThresholdUnit Mb = new("MB");

    public static readonly ThresholdUnit Gb = new("GB");

    public TResult Match<TResult>(Func<TResult> onKb,
        Func<TResult> onMb,
        Func<TResult> onGb,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Kb => onKb(),
            _ when this == Mb => onMb(),
            _ when this == Gb => onGb(),
            _ => otherwise(Value)
        };

    public void Match(Action onKb, Action onMb, Action onGb, Action<string> otherwise)
    {
        if (this == Kb) onKb();
        else if (this == Mb) onMb();
        else if (this == Gb) onGb();
        else otherwise(Value);
    }
}
