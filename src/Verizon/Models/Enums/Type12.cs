using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of ice.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type12>))]
public sealed record Type12 : OpenStringEnum<Type12>
{
    private Type12(string value) : base(value)
    {
    }

    public static readonly Type12 Smooth = new("smooth");

    public TResult Match<TResult>(Func<TResult> onSmooth, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Smooth => onSmooth(),
            _ => otherwise(Value)
        };

    public void Match(Action onSmooth, Action<string> otherwise)
    {
        if (this == Smooth) onSmooth();
        else otherwise(Value);
    }
}
