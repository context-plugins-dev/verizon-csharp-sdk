using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The following options are supported as Trigger TriggerConditions:
///   - enter: The message is triggered when the road user enters the geofence. For polygons and multi-polygons only. In case of multi-polygons the message is triggered when the road user enters any of the polygons.
///   - leave: The message is triggered when the road user leaves the geofence. For polygons and multi-polygons only. In case of multi-polygons the message is triggered when the road user leaves any of the polygons.
///   - inside: The message is triggered when the road user is inside the geofence. For polygons and multi-polygons only. In case of multi-polygons the message is triggered when the road user is inside any of the polygons.
///   - crossing: The message is triggered when the road user crosses the geofence. For lines and multi-lines only. In case of multi-lines the message is triggered when the road user crosses any of the lines.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TriggerCondition>))]
public sealed record TriggerCondition : OpenStringEnum<TriggerCondition>
{
    private TriggerCondition(string value) : base(value)
    {
    }

    public static readonly TriggerCondition Enter = new("enter");

    public static readonly TriggerCondition Leave = new("leave");

    public static readonly TriggerCondition Inside = new("inside");

    public static readonly TriggerCondition Crossing = new("crossing");

    public TResult Match<TResult>(Func<TResult> onEnter,
        Func<TResult> onLeave,
        Func<TResult> onInside,
        Func<TResult> onCrossing,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Enter => onEnter(),
            _ when this == Leave => onLeave(),
            _ when this == Inside => onInside(),
            _ when this == Crossing => onCrossing(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnter, Action onLeave, Action onInside, Action onCrossing, Action<string> otherwise)
    {
        if (this == Enter) onEnter();
        else if (this == Leave) onLeave();
        else if (this == Inside) onInside();
        else if (this == Crossing) onCrossing();
        else otherwise(Value);
    }
}
