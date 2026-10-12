using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of trigger being created or modified
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TriggerCategory>))]
public sealed record TriggerCategory : OpenStringEnum<TriggerCategory>
{
    private TriggerCategory(string value) : base(value)
    {
    }

    public static readonly TriggerCategory AccountUsage = new("AccountUsage");

    public static readonly TriggerCategory DeviceGroupUsage = new("DeviceGroupUsage");

    public static readonly TriggerCategory PricePlanDataUsage = new("PricePlanDataUsage");

    public TResult Match<TResult>(Func<TResult> onAccountUsage,
        Func<TResult> onDeviceGroupUsage,
        Func<TResult> onPricePlanDataUsage,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == AccountUsage => onAccountUsage(),
            _ when this == DeviceGroupUsage => onDeviceGroupUsage(),
            _ when this == PricePlanDataUsage => onPricePlanDataUsage(),
            _ => otherwise(Value)
        };

    public void Match(Action onAccountUsage,
        Action onDeviceGroupUsage,
        Action onPricePlanDataUsage,
        Action<string> otherwise)
    {
        if (this == AccountUsage) onAccountUsage();
        else if (this == DeviceGroupUsage) onDeviceGroupUsage();
        else if (this == PricePlanDataUsage) onPricePlanDataUsage();
        else otherwise(Value);
    }
}
