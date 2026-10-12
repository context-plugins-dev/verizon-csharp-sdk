using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : OpenStringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 Polygon = new("Polygon");

    public TResult Match<TResult>(Func<TResult> onPolygon, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Polygon => onPolygon(),
            _ => otherwise(Value)
        };

    public void Match(Action onPolygon, Action<string> otherwise)
    {
        if (this == Polygon) onPolygon();
        else otherwise(Value);
    }
}
