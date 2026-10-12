using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type5>))]
public sealed record Type5 : OpenStringEnum<Type5>
{
    private Type5(string value) : base(value)
    {
    }

    public static readonly Type5 MultiPolygon = new("MultiPolygon");

    public TResult Match<TResult>(Func<TResult> onMultiPolygon, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MultiPolygon => onMultiPolygon(),
            _ => otherwise(Value)
        };

    public void Match(Action onMultiPolygon, Action<string> otherwise)
    {
        if (this == MultiPolygon) onMultiPolygon();
        else otherwise(Value);
    }
}
