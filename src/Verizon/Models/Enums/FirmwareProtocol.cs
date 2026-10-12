using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMD-DM, all.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FirmwareProtocol>))]
public sealed record FirmwareProtocol : OpenStringEnum<FirmwareProtocol>
{
    private FirmwareProtocol(string value) : base(value)
    {
    }

    public static readonly FirmwareProtocol Lwm2M = new("LWM2M");

    public static readonly FirmwareProtocol OmdDm = new("OMD-DM");

    public static readonly FirmwareProtocol All = new("all");

    public TResult Match<TResult>(Func<TResult> onLwm2M,
        Func<TResult> onOmdDm,
        Func<TResult> onAll,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Lwm2M => onLwm2M(),
            _ when this == OmdDm => onOmdDm(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onLwm2M, Action onOmdDm, Action onAll, Action<string> otherwise)
    {
        if (this == Lwm2M) onLwm2M();
        else if (this == OmdDm) onOmdDm();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
