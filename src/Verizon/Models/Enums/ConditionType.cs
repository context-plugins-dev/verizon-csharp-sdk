using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The condition type being monitored
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConditionType>))]
public sealed record ConditionType : OpenStringEnum<ConditionType>
{
    private ConditionType(string value) : base(value)
    {
    }

    public static readonly ConditionType Individual = new("Individual");

    public static readonly ConditionType Aging = new("Aging");

    public static readonly ConditionType UsageAllowance = new("UsageAllowance");

    public TResult Match<TResult>(Func<TResult> onIndividual,
        Func<TResult> onAging,
        Func<TResult> onUsageAllowance,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Individual => onIndividual(),
            _ when this == Aging => onAging(),
            _ when this == UsageAllowance => onUsageAllowance(),
            _ => otherwise(Value)
        };

    public void Match(Action onIndividual, Action onAging, Action onUsageAllowance, Action<string> otherwise)
    {
        if (this == Individual) onIndividual();
        else if (this == Aging) onAging();
        else if (this == UsageAllowance) onUsageAllowance();
        else otherwise(Value);
    }
}
