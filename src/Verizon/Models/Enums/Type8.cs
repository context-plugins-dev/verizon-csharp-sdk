using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Indicates the type of gravel.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type8>))]
public sealed record Type8 : OpenStringEnum<Type8>
{
    private Type8(string value) : base(value)
    {
    }

    public static readonly Type8 PackedOiled = new("packedOiled");

    public static readonly Type8 Loose = new("loose");

    public TResult Match<TResult>(Func<TResult> onPackedOiled,
        Func<TResult> onLoose,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PackedOiled => onPackedOiled(),
            _ when this == Loose => onLoose(),
            _ => otherwise(Value)
        };

    public void Match(Action onPackedOiled, Action onLoose, Action<string> otherwise)
    {
        if (this == PackedOiled) onPackedOiled();
        else if (this == Loose) onLoose();
        else otherwise(Value);
    }
}
