using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Type1>))]
public sealed record Type1 : OpenStringEnum<Type1>
{
    private Type1(string value) : base(value)
    {
    }

    public static readonly Type1 Feature = new("Feature");

    public TResult Match<TResult>(Func<TResult> onFeature, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Feature => onFeature(),
            _ => otherwise(Value)
        };

    public void Match(Action onFeature, Action<string> otherwise)
    {
        if (this == Feature) onFeature();
        else otherwise(Value);
    }
}
