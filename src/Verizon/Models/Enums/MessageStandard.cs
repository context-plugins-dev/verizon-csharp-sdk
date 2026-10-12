using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Select which V2X messaging standard will be used for the message generation. The following options are supported:
///   - "etsi": The message will be generated using the ETSI (European) standard (e.g. DENM).
///   - "sae": The message will be generated using the SAE J2735 (North American) standard (e.g. RSA, TIM).
///   - if not sent while POST, defaults to "sae"
///   - mandatory to send "etsi" standard here, if ETSI messages are being sent in config
/// </summary>
[JsonConverter(typeof(StringEnumConverter<MessageStandard>))]
public sealed record MessageStandard : OpenStringEnum<MessageStandard>
{
    private MessageStandard(string value) : base(value)
    {
    }

    public static readonly MessageStandard Etsi = new("etsi");

    public static readonly MessageStandard Sae = new("sae");

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
