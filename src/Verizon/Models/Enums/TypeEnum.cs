using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum FeatureCollection = new("FeatureCollection");

    public TResult Match<TResult>(Func<TResult> onFeatureCollection, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == FeatureCollection => onFeatureCollection(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeatureCollection, Action<string> otherwise)
    {
        if (this == FeatureCollection) onFeatureCollection();
        else otherwise(Value);
    }
}
