using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Possible values are <c>append</c> or <c>remove</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FirmwareTypeList>))]
public sealed record FirmwareTypeList : OpenStringEnum<FirmwareTypeList>
{
    private FirmwareTypeList(string value) : base(value)
    {
    }

    public static readonly FirmwareTypeList Append = new("append");

    public static readonly FirmwareTypeList Remove = new("remove");

    public TResult Match<TResult>(Func<TResult> onAppend, Func<TResult> onRemove, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Append => onAppend(),
            _ when this == Remove => onRemove(),
            _ => otherwise(Value)
        };

    public void Match(Action onAppend, Action onRemove, Action<string> otherwise)
    {
        if (this == Append) onAppend();
        else if (this == Remove) onRemove();
        else otherwise(Value);
    }
}
