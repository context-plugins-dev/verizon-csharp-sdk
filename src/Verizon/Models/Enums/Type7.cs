using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of asphalt or tar.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type7>))]
public sealed record Type7 : OpenStringEnum<Type7>
{
    private Type7(string value) : base(value)
    {
    }

    public static readonly Type7 NewSharp = new("newSharp");

    public static readonly Type7 Traveled = new("traveled");

    public static readonly Type7 TrafficPolished = new("trafficPolished");

    public static readonly Type7 ExcessTar = new("excessTar");

    public TResult Match<TResult>(Func<TResult> onNewSharp,
        Func<TResult> onTraveled,
        Func<TResult> onTrafficPolished,
        Func<TResult> onExcessTar,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NewSharp => onNewSharp(),
            _ when this == Traveled => onTraveled(),
            _ when this == TrafficPolished => onTrafficPolished(),
            _ when this == ExcessTar => onExcessTar(),
            _ => otherwise(Value)
        };

    public void Match(Action onNewSharp,
        Action onTraveled,
        Action onTrafficPolished,
        Action onExcessTar,
        Action<string> otherwise)
    {
        if (this == NewSharp) onNewSharp();
        else if (this == Traveled) onTraveled();
        else if (this == TrafficPolished) onTrafficPolished();
        else if (this == ExcessTar) onExcessTar();
        else otherwise(Value);
    }
}
