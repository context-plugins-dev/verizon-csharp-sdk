using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : OpenStringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 MultiLineString = new("MultiLineString");

    public TResult Match<TResult>(Func<TResult> onMultiLineString, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MultiLineString => onMultiLineString(),
            _ => otherwise(Value)
        };

    public void Match(Action onMultiLineString, Action<string> otherwise)
    {
        if (this == MultiLineString) onMultiLineString();
        else otherwise(Value);
    }
}
