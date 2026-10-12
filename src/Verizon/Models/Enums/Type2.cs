using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type2>))]
public sealed record Type2 : OpenStringEnum<Type2>
{
    private Type2(string value) : base(value)
    {
    }

    public static readonly Type2 LineString = new("LineString");

    public TResult Match<TResult>(Func<TResult> onLineString, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LineString => onLineString(),
            _ => otherwise(Value)
        };

    public void Match(Action onLineString, Action<string> otherwise)
    {
        if (this == LineString) onLineString();
        else otherwise(Value);
    }
}
