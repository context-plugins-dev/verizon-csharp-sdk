using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of rock.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type11>))]
public sealed record Type11 : OpenStringEnum<Type11>
{
    private Type11(string value) : base(value)
    {
    }

    public static readonly Type11 Crushed = new("crushed");

    public TResult Match<TResult>(Func<TResult> onCrushed, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Crushed => onCrushed(),
            _ => otherwise(Value)
        };

    public void Match(Action onCrushed, Action<string> otherwise)
    {
        if (this == Crushed) onCrushed();
        else otherwise(Value);
    }
}
