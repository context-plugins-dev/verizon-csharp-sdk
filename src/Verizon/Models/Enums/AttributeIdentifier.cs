using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Attribute identifier.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AttributeIdentifier>))]
public sealed record AttributeIdentifier : OpenStringEnum<AttributeIdentifier>
{
    private AttributeIdentifier(string value) : base(value)
    {
    }

    public static readonly AttributeIdentifier NetworkBearer = new("NETWORK_BEARER");

    public static readonly AttributeIdentifier RadioSignalStrength = new("RADIO_SIGNAL_STRENGTH");

    public static readonly AttributeIdentifier LinkQuality = new("LINK_QUALITY");

    public static readonly AttributeIdentifier CellId = new("CELL_ID");

    public static readonly AttributeIdentifier Manufacturer = new("MANUFACTURER");

    public TResult Match<TResult>(Func<TResult> onNetworkBearer,
        Func<TResult> onRadioSignalStrength,
        Func<TResult> onLinkQuality,
        Func<TResult> onCellId,
        Func<TResult> onManufacturer,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NetworkBearer => onNetworkBearer(),
            _ when this == RadioSignalStrength => onRadioSignalStrength(),
            _ when this == LinkQuality => onLinkQuality(),
            _ when this == CellId => onCellId(),
            _ when this == Manufacturer => onManufacturer(),
            _ => otherwise(Value)
        };

    public void Match(Action onNetworkBearer,
        Action onRadioSignalStrength,
        Action onLinkQuality,
        Action onCellId,
        Action onManufacturer,
        Action<string> otherwise)
    {
        if (this == NetworkBearer) onNetworkBearer();
        else if (this == RadioSignalStrength) onRadioSignalStrength();
        else if (this == LinkQuality) onLinkQuality();
        else if (this == CellId) onCellId();
        else if (this == Manufacturer) onManufacturer();
        else otherwise(Value);
    }
}
