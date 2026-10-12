using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The action taken when trigger conditions are met
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ConditionAction>))]
public sealed record ConditionAction : OpenStringEnum<ConditionAction>
{
    private ConditionAction(string value) : base(value)
    {
    }

    public static readonly ConditionAction Notify = new("notify");

    public static readonly ConditionAction Suspend = new("suspend");

    public static readonly ConditionAction ChangePricePlan = new("changePricePlan");

    public TResult Match<TResult>(Func<TResult> onNotify,
        Func<TResult> onSuspend,
        Func<TResult> onChangePricePlan,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Notify => onNotify(),
            _ when this == Suspend => onSuspend(),
            _ when this == ChangePricePlan => onChangePricePlan(),
            _ => otherwise(Value)
        };

    public void Match(Action onNotify, Action onSuspend, Action onChangePricePlan, Action<string> otherwise)
    {
        if (this == Notify) onNotify();
        else if (this == Suspend) onSuspend();
        else if (this == ChangePricePlan) onChangePricePlan();
        else otherwise(Value);
    }
}
