using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<CycleType>))]
public sealed record CycleType : OpenStringEnum<CycleType>
{
    private CycleType(string value) : base(value)
    {
    }

    public static readonly CycleType Cycleone = new("cycleone");

    public static readonly CycleType Cycletwo = new("cycletwo");

    public TResult Match<TResult>(Func<TResult> onCycleone,
        Func<TResult> onCycletwo,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Cycleone => onCycleone(),
            _ when this == Cycletwo => onCycletwo(),
            _ => otherwise(Value)
        };

    public void Match(Action onCycleone, Action onCycletwo, Action<string> otherwise)
    {
        if (this == Cycleone) onCycleone();
        else if (this == Cycletwo) onCycletwo();
        else otherwise(Value);
    }
}
