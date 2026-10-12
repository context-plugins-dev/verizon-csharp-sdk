using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// A flag to indicate of the trigger is active, true, or not, false
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Active>))]
public sealed record Active : OpenStringEnum<Active>
{
    private Active(string value) : base(value)
    {
    }

    public static readonly Active True = new("true");

    public static readonly Active False = new("false");

    public TResult Match<TResult>(Func<TResult> onTrue, Func<TResult> onFalse, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == True => onTrue(),
            _ when this == False => onFalse(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrue, Action onFalse, Action<string> otherwise)
    {
        if (this == True) onTrue();
        else if (this == False) onFalse();
        else otherwise(Value);
    }
}
