using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of portland cement.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : OpenStringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 NewSharp = new("newSharp");

    public static readonly Type6 Traveled = new("traveled");

    public static readonly Type6 TrafficPolished = new("trafficPolished");

    public TResult Match<TResult>(Func<TResult> onNewSharp,
        Func<TResult> onTraveled,
        Func<TResult> onTrafficPolished,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NewSharp => onNewSharp(),
            _ when this == Traveled => onTraveled(),
            _ when this == TrafficPolished => onTrafficPolished(),
            _ => otherwise(Value)
        };

    public void Match(Action onNewSharp, Action onTraveled, Action onTrafficPolished, Action<string> otherwise)
    {
        if (this == NewSharp) onNewSharp();
        else if (this == Traveled) onTraveled();
        else if (this == TrafficPolished) onTrafficPolished();
        else otherwise(Value);
    }
}
