using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The status of the upgrades that you want to retrieve.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<UpgradeStatus>))]
public sealed record UpgradeStatus : OpenStringEnum<UpgradeStatus>
{
    private UpgradeStatus(string value) : base(value)
    {
    }

    public static readonly UpgradeStatus RequestPending = new("RequestPending");

    public static readonly UpgradeStatus Queued = new("Queued");

    public static readonly UpgradeStatus RequestFailed = new("RequestFailed");

    public static readonly UpgradeStatus InProgress = new("InProgress");

    public static readonly UpgradeStatus Finished = new("Finished");

    public static readonly UpgradeStatus UpgradeFailed = new("UpgradeFailed");

    public TResult Match<TResult>(Func<TResult> onRequestPending,
        Func<TResult> onQueued,
        Func<TResult> onRequestFailed,
        Func<TResult> onInProgress,
        Func<TResult> onFinished,
        Func<TResult> onUpgradeFailed,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == RequestPending => onRequestPending(),
            _ when this == Queued => onQueued(),
            _ when this == RequestFailed => onRequestFailed(),
            _ when this == InProgress => onInProgress(),
            _ when this == Finished => onFinished(),
            _ when this == UpgradeFailed => onUpgradeFailed(),
            _ => otherwise(Value)
        };

    public void Match(Action onRequestPending,
        Action onQueued,
        Action onRequestFailed,
        Action onInProgress,
        Action onFinished,
        Action onUpgradeFailed,
        Action<string> otherwise)
    {
        if (this == RequestPending) onRequestPending();
        else if (this == Queued) onQueued();
        else if (this == RequestFailed) onRequestFailed();
        else if (this == InProgress) onInProgress();
        else if (this == Finished) onFinished();
        else if (this == UpgradeFailed) onUpgradeFailed();
        else otherwise(Value);
    }
}
