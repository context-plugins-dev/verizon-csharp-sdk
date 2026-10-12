using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The frameType data element provides the type of message to follow in the rest of the message frame structure. The following frame types are supported:
///  - unknown
///  - advisory
///  - roadSignage
///  - commercialSignage
/// </summary>
[JsonConverter(typeof(StringEnumConverter<FrameType>))]
public sealed record FrameType : OpenStringEnum<FrameType>
{
    private FrameType(string value) : base(value)
    {
    }

    public static readonly FrameType Unknown = new("unknown");

    public static readonly FrameType Advisory = new("advisory");

    public static readonly FrameType RoadSignage = new("roadSignage");

    public static readonly FrameType CommercialSignage = new("commercialSignage");

    public TResult Match<TResult>(Func<TResult> onUnknown,
        Func<TResult> onAdvisory,
        Func<TResult> onRoadSignage,
        Func<TResult> onCommercialSignage,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unknown => onUnknown(),
            _ when this == Advisory => onAdvisory(),
            _ when this == RoadSignage => onRoadSignage(),
            _ when this == CommercialSignage => onCommercialSignage(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnknown,
        Action onAdvisory,
        Action onRoadSignage,
        Action onCommercialSignage,
        Action<string> otherwise)
    {
        if (this == Unknown) onUnknown();
        else if (this == Advisory) onAdvisory();
        else if (this == RoadSignage) onRoadSignage();
        else if (this == CommercialSignage) onCommercialSignage();
        else otherwise(Value);
    }
}
