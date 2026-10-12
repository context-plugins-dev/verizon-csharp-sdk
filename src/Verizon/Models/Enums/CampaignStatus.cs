using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Current status of the campaign.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CampaignStatus>))]
public sealed record CampaignStatus : OpenStringEnum<CampaignStatus>
{
    private CampaignStatus(string value) : base(value)
    {
    }

    public static readonly CampaignStatus CampaignRequestPending = new("CampaignRequestPending");

    public static readonly CampaignStatus CampaignRequestFailed = new("CampaignRequestFailed");

    public static readonly CampaignStatus CampaignRequestQueued = new("CampaignRequestQueued");

    public static readonly CampaignStatus CampaignCancelled = new("CampaignCancelled");

    public static readonly CampaignStatus CampaignAborted = new("CampaignAborted");

    public static readonly CampaignStatus CampaignFailed = new("CampaignFailed");

    public static readonly CampaignStatus CampaignScheduled = new("CampaignScheduled");

    public static readonly CampaignStatus CampaignEnded = new("CampaignEnded");

    public TResult Match<TResult>(Func<TResult> onCampaignRequestPending,
        Func<TResult> onCampaignRequestFailed,
        Func<TResult> onCampaignRequestQueued,
        Func<TResult> onCampaignCancelled,
        Func<TResult> onCampaignAborted,
        Func<TResult> onCampaignFailed,
        Func<TResult> onCampaignScheduled,
        Func<TResult> onCampaignEnded,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == CampaignRequestPending => onCampaignRequestPending(),
            _ when this == CampaignRequestFailed => onCampaignRequestFailed(),
            _ when this == CampaignRequestQueued => onCampaignRequestQueued(),
            _ when this == CampaignCancelled => onCampaignCancelled(),
            _ when this == CampaignAborted => onCampaignAborted(),
            _ when this == CampaignFailed => onCampaignFailed(),
            _ when this == CampaignScheduled => onCampaignScheduled(),
            _ when this == CampaignEnded => onCampaignEnded(),
            _ => otherwise(Value)
        };

    public void Match(Action onCampaignRequestPending,
        Action onCampaignRequestFailed,
        Action onCampaignRequestQueued,
        Action onCampaignCancelled,
        Action onCampaignAborted,
        Action onCampaignFailed,
        Action onCampaignScheduled,
        Action onCampaignEnded,
        Action<string> otherwise)
    {
        if (this == CampaignRequestPending) onCampaignRequestPending();
        else if (this == CampaignRequestFailed) onCampaignRequestFailed();
        else if (this == CampaignRequestQueued) onCampaignRequestQueued();
        else if (this == CampaignCancelled) onCampaignCancelled();
        else if (this == CampaignAborted) onCampaignAborted();
        else if (this == CampaignFailed) onCampaignFailed();
        else if (this == CampaignScheduled) onCampaignScheduled();
        else if (this == CampaignEnded) onCampaignEnded();
        else otherwise(Value);
    }
}
