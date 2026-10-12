using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Firmware protocol. Valid values include: LWM2M, OMD-DM.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CampaignMetaInfoProtocol>))]
public sealed record CampaignMetaInfoProtocol : OpenStringEnum<CampaignMetaInfoProtocol>
{
    private CampaignMetaInfoProtocol(string value) : base(value)
    {
    }

    public static readonly CampaignMetaInfoProtocol Lwm2M = new("LWM2M");

    public static readonly CampaignMetaInfoProtocol OmdDm = new("OMD-DM");

    public TResult Match<TResult>(Func<TResult> onLwm2M, Func<TResult> onOmdDm, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Lwm2M => onLwm2M(),
            _ when this == OmdDm => onOmdDm(),
            _ => otherwise(Value)
        };

    public void Match(Action onLwm2M, Action onOmdDm, Action<string> otherwise)
    {
        if (this == Lwm2M) onLwm2M();
        else if (this == OmdDm) onOmdDm();
        else otherwise(Value);
    }
}
