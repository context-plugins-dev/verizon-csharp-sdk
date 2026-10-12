using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of snow.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type13>))]
public sealed record Type13 : OpenStringEnum<Type13>
{
    private Type13(string value) : base(value)
    {
    }

    public static readonly Type13 Packed = new("packed");

    public static readonly Type13 Loose = new("loose");

    public TResult Match<TResult>(Func<TResult> onPacked, Func<TResult> onLoose, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Packed => onPacked(),
            _ when this == Loose => onLoose(),
            _ => otherwise(Value)
        };

    public void Match(Action onPacked, Action onLoose, Action<string> otherwise)
    {
        if (this == Packed) onPacked();
        else if (this == Loose) onLoose();
        else otherwise(Value);
    }
}
