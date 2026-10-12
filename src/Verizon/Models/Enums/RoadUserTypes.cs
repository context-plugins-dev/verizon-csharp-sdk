using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The road user types:
///   - Vehicle: Vehicles with a metal box. Example: Car, Truck, Bus, etc.
///   - VulnerableRoadUser: Road users without protective housing. Example: Pedestrian, Cyclist, Motorcyclist, etc.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RoadUserTypes>))]
public sealed record RoadUserTypes : OpenStringEnum<RoadUserTypes>
{
    private RoadUserTypes(string value) : base(value)
    {
    }

    public static readonly RoadUserTypes VulnerableRoadUser = new("VulnerableRoadUser");

    public static readonly RoadUserTypes Vehicle = new("Vehicle");

    public TResult Match<TResult>(Func<TResult> onVulnerableRoadUser,
        Func<TResult> onVehicle,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == VulnerableRoadUser => onVulnerableRoadUser(),
            _ when this == Vehicle => onVehicle(),
            _ => otherwise(Value)
        };

    public void Match(Action onVulnerableRoadUser, Action onVehicle, Action<string> otherwise)
    {
        if (this == VulnerableRoadUser) onVulnerableRoadUser();
        else if (this == Vehicle) onVehicle();
        else otherwise(Value);
    }
}
