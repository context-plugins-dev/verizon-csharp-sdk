using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The distribution types:
///   - Targeted: Generate targeted messages to the road users that are affected by the zone rules
///   - Broadcast: Broadcast messages to regions based on the Geofence.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DistributionTypes>))]
public sealed record DistributionTypes : OpenStringEnum<DistributionTypes>
{
    private DistributionTypes(string value) : base(value)
    {
    }

    public static readonly DistributionTypes Targeted = new("Targeted");

    public static readonly DistributionTypes Broadcast = new("Broadcast");

    public TResult Match<TResult>(Func<TResult> onTargeted,
        Func<TResult> onBroadcast,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Targeted => onTargeted(),
            _ when this == Broadcast => onBroadcast(),
            _ => otherwise(Value)
        };

    public void Match(Action onTargeted, Action onBroadcast, Action<string> otherwise)
    {
        if (this == Targeted) onTargeted();
        else if (this == Broadcast) onBroadcast();
        else otherwise(Value);
    }
}
