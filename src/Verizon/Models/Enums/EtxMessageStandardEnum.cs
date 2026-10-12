using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// V2X messaging standard selection. Accepted values are 'sae' (SAE J2735) and 'etsi' (ETSI TS 103 301).
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxMessageStandardEnum>))]
public sealed record EtxMessageStandardEnum : OpenStringEnum<EtxMessageStandardEnum>
{
    private EtxMessageStandardEnum(string value) : base(value)
    {
    }

    public static readonly EtxMessageStandardEnum Etsi = new("etsi");

    public static readonly EtxMessageStandardEnum Sae = new("sae");

    public TResult Match<TResult>(Func<TResult> onEtsi, Func<TResult> onSae, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Etsi => onEtsi(),
            _ when this == Sae => onSae(),
            _ => otherwise(Value)
        };

    public void Match(Action onEtsi, Action onSae, Action<string> otherwise)
    {
        if (this == Etsi) onEtsi();
        else if (this == Sae) onSae();
        else otherwise(Value);
    }
}
