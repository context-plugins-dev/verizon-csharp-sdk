using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The interval to monitor for the threshold. This can be Daily, Weekly or Monthly
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RulesCycleType>))]
public sealed record RulesCycleType : OpenStringEnum<RulesCycleType>
{
    private RulesCycleType(string value) : base(value)
    {
    }

    public static readonly RulesCycleType Daily = new("Daily");

    public static readonly RulesCycleType Weekly = new("Weekly");

    public static readonly RulesCycleType Monthly = new("Monthly");

    public TResult Match<TResult>(Func<TResult> onDaily,
        Func<TResult> onWeekly,
        Func<TResult> onMonthly,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Daily => onDaily(),
            _ when this == Weekly => onWeekly(),
            _ when this == Monthly => onMonthly(),
            _ => otherwise(Value)
        };

    public void Match(Action onDaily, Action onWeekly, Action onMonthly, Action<string> otherwise)
    {
        if (this == Daily) onDaily();
        else if (this == Weekly) onWeekly();
        else if (this == Monthly) onMonthly();
        else otherwise(Value);
    }
}
