using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Type of the GeoJSON geometry, must be 'Polygon'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxMapMessageGeofenceGeometry>))]
public sealed record EtxMapMessageGeofenceGeometry : OpenStringEnum<EtxMapMessageGeofenceGeometry>
{
    private EtxMapMessageGeofenceGeometry(string value) : base(value)
    {
    }

    public static readonly EtxMapMessageGeofenceGeometry Polygon = new("Polygon");

    public TResult Match<TResult>(Func<TResult> onPolygon, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Polygon => onPolygon(),
            _ => otherwise(Value)
        };

    public void Match(Action onPolygon, Action<string> otherwise)
    {
        if (this == Polygon) onPolygon();
        else otherwise(Value);
    }
}
