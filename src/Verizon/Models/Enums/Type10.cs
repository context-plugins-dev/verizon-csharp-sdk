using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of cinders.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type10>))]
public sealed record Type10 : OpenStringEnum<Type10>
{
    private Type10(string value) : base(value)
    {
    }

    public static readonly Type10 Packed = new("packed");

    public TResult Match<TResult>(Func<TResult> onPacked, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Packed => onPacked(),
            _ => otherwise(Value)
        };

    public void Match(Action onPacked, Action<string> otherwise)
    {
        if (this == Packed) onPacked();
        else otherwise(Value);
    }
}
