using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The action taken when trigger conditions are met
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AccountLevelAction>))]
public sealed record AccountLevelAction : OpenStringEnum<AccountLevelAction>
{
    private AccountLevelAction(string value) : base(value)
    {
    }

    public static readonly AccountLevelAction Notify = new("notify");

    public static readonly AccountLevelAction Suspend = new("suspend");

    public static readonly AccountLevelAction ChangePricePlan = new("changePricePlan");

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
