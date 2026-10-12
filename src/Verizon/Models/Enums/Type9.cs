using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the surface of the roadway is grass with low speed limit.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type9>))]
public sealed record Type9 : OpenStringEnum<Type9>
{
    private Type9(string value) : base(value)
    {
    }

    public static readonly Type9 LessThan30Mph = new("lessThan30Mph");

    public TResult Match<TResult>(Func<TResult> onLessThan30Mph, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == LessThan30Mph => onLessThan30Mph(),
            _ => otherwise(Value)
        };

    public void Match(Action onLessThan30Mph, Action<string> otherwise)
    {
        if (this == LessThan30Mph) onLessThan30Mph();
        else otherwise(Value);
    }
}
