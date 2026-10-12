using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMADM, HTTP.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DevicesProtocol>))]
public sealed record DevicesProtocol : OpenStringEnum<DevicesProtocol>
{
    private DevicesProtocol(string value) : base(value)
    {
    }

    public static readonly DevicesProtocol Lwm2M = new("LWM2M");

    public static readonly DevicesProtocol Omdadm = new("OMDADM");

    public static readonly DevicesProtocol Http = new("HTTP");

    public TResult Match<TResult>(Func<TResult> onLwm2M,
        Func<TResult> onOmdadm,
        Func<TResult> onHttp,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Lwm2M => onLwm2M(),
            _ when this == Omdadm => onOmdadm(),
            _ when this == Http => onHttp(),
            _ => otherwise(Value)
        };

    public void Match(Action onLwm2M, Action onOmdadm, Action onHttp, Action<string> otherwise)
    {
        if (this == Lwm2M) onLwm2M();
        else if (this == Omdadm) onOmdadm();
        else if (this == Http) onHttp();
        else otherwise(Value);
    }
}
