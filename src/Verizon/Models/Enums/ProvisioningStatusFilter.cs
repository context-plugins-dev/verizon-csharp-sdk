using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The last status of the device as a list filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProvisioningStatusFilter>))]
public sealed record ProvisioningStatusFilter : OpenStringEnum<ProvisioningStatusFilter>
{
    private ProvisioningStatusFilter(string value) : base(value)
    {
    }

    public static readonly ProvisioningStatusFilter Unknown = new("UNKNOWN");

    public static readonly ProvisioningStatusFilter Deactivated = new("DEACTIVATED");

    public static readonly ProvisioningStatusFilter Activated = new("ACTIVATED");

    public static readonly ProvisioningStatusFilter Deactive = new("DEACTIVE");

    public static readonly ProvisioningStatusFilter Active = new("ACTIVE");

    public static readonly ProvisioningStatusFilter Suspend = new("SUSPEND");

    public static readonly ProvisioningStatusFilter PendingActivation = new("PENDING_ACTIVATION");

    public static readonly ProvisioningStatusFilter PendingDeactivation = new("PENDING_DEACTIVATION");

    public static readonly ProvisioningStatusFilter PreActive = new("PRE_ACTIVE");

    public static readonly ProvisioningStatusFilter ActivationReady = new("ACTIVATION_READY");

    public static readonly ProvisioningStatusFilter Inventory = new("INVENTORY");

    public static readonly ProvisioningStatusFilter Purged = new("PURGED");

    public static readonly ProvisioningStatusFilter Replaced = new("REPLACED");

    public static readonly ProvisioningStatusFilter Retired = new("RETIRED");

    public static readonly ProvisioningStatusFilter TestReady = new("TEST_READY");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onDeactivated,
        Func<TResult> onActivated,
        Func<TResult> onDeactive,
        Func<TResult> onActive,
        Func<TResult> onSuspend,
        Func<TResult> onPendingActivation,
        Func<TResult> onPendingDeactivation,
        Func<TResult> onPreActive,
        Func<TResult> onActivationReady,
        Func<TResult> onInventory,
        Func<TResult> onPurged,
        Func<TResult> onReplaced,
        Func<TResult> onRetired,
        Func<TResult> onTestReady,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Deactivated => onDeactivated(),
            _ when this == Activated => onActivated(),
            _ when this == Deactive => onDeactive(),
            _ when this == Active => onActive(),
            _ when this == Suspend => onSuspend(),
            _ when this == PendingActivation => onPendingActivation(),
            _ when this == PendingDeactivation => onPendingDeactivation(),
            _ when this == PreActive => onPreActive(),
            _ when this == ActivationReady => onActivationReady(),
            _ when this == Inventory => onInventory(),
            _ when this == Purged => onPurged(),
            _ when this == Replaced => onReplaced(),
            _ when this == Retired => onRetired(),
            _ when this == TestReady => onTestReady(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onDeactivated,
        Action onActivated,
        Action onDeactive,
        Action onActive,
        Action onSuspend,
        Action onPendingActivation,
        Action onPendingDeactivation,
        Action onPreActive,
        Action onActivationReady,
        Action onInventory,
        Action onPurged,
        Action onReplaced,
        Action onRetired,
        Action onTestReady,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Deactivated) onDeactivated();
        else if (this == Activated) onActivated();
        else if (this == Deactive) onDeactive();
        else if (this == Active) onActive();
        else if (this == Suspend) onSuspend();
        else if (this == PendingActivation) onPendingActivation();
        else if (this == PendingDeactivation) onPendingDeactivation();
        else if (this == PreActive) onPreActive();
        else if (this == ActivationReady) onActivationReady();
        else if (this == Inventory) onInventory();
        else if (this == Purged) onPurged();
        else if (this == Replaced) onReplaced();
        else if (this == Retired) onRetired();
        else if (this == TestReady) onTestReady();
        else otherwise(Value);
    }
}
