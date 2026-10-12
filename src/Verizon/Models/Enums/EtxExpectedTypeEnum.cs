using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The format of the payload in the response body.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxExpectedTypeEnum>))]
public sealed record EtxExpectedTypeEnum : OpenStringEnum<EtxExpectedTypeEnum>
{
    private EtxExpectedTypeEnum(string value) : base(value)
    {
    }

    public static readonly EtxExpectedTypeEnum Base64 = new("BASE64");

    public static readonly EtxExpectedTypeEnum Json = new("JSON");

    public TResult Match<TResult>(Func<TResult> onBase64, Func<TResult> onJson, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Base64 => onBase64(),
            _ when this == Json => onJson(),
            _ => otherwise(Value)
        };

    public void Match(Action onBase64, Action onJson, Action<string> otherwise)
    {
        if (this == Base64) onBase64();
        else if (this == Json) onJson();
        else otherwise(Value);
    }
}
