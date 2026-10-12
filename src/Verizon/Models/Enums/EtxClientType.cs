using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of the client that is to be registered. This is one of the major traffic participant groups considered in V2X communication. The system uses this value to define which topics the client will be able to publish and subscribe to.
/// <para>
/// Values:
/// - <b>Vehicle</b> - Vehicle with an enclosure around the passengers. (Subtypes: Motorcycle, PassengerCar, Truck, Bus, EmergencyVehicle, SchoolBus, MaintenanceVehicle)
/// - <b>VulnerableRoadUser</b> - Traffic participants without a protecting enclosure. (Subtypes: Bicycle, Pedestrian, Scooter)
/// - <b>TrafficLightController</b> - A Traffic light controller system. (Subtypes: NA)
/// - <b>InfrastructureSensor</b> - Sensors that are deployed in the infrastructure. (Subtypes: RoadSideUnit, Camera, Lidar, Radar, InductiveLoop, MagneticSensor)
/// - <b>OnboardSensor</b> - Sensors that are onboard on a vehicle(Subtypes: Camera, Lidar, Radar)
/// - <b>Software</b> - A software system or application. (Subtypes: Platform, Application, NA)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EtxClientType>))]
public sealed record EtxClientType : OpenStringEnum<EtxClientType>
{
    private EtxClientType(string value) : base(value)
    {
    }

    public static readonly EtxClientType Vehicle = new("Vehicle");

    public static readonly EtxClientType VulnerableRoadUser = new("VulnerableRoadUser");

    public static readonly EtxClientType TrafficLightController = new("TrafficLightController");

    public static readonly EtxClientType InfrastructureSensor = new("InfrastructureSensor");

    public static readonly EtxClientType OnboardSensor = new("OnboardSensor");

    public static readonly EtxClientType Software = new("Software");

    public TResult Match<TResult>(Func<TResult> onVehicle,
        Func<TResult> onVulnerableRoadUser,
        Func<TResult> onTrafficLightController,
        Func<TResult> onInfrastructureSensor,
        Func<TResult> onOnboardSensor,
        Func<TResult> onSoftware,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vehicle => onVehicle(),
            _ when this == VulnerableRoadUser => onVulnerableRoadUser(),
            _ when this == TrafficLightController => onTrafficLightController(),
            _ when this == InfrastructureSensor => onInfrastructureSensor(),
            _ when this == OnboardSensor => onOnboardSensor(),
            _ when this == Software => onSoftware(),
            _ => otherwise(Value)
        };

    public void Match(Action onVehicle,
        Action onVulnerableRoadUser,
        Action onTrafficLightController,
        Action onInfrastructureSensor,
        Action onOnboardSensor,
        Action onSoftware,
        Action<string> otherwise)
    {
        if (this == Vehicle) onVehicle();
        else if (this == VulnerableRoadUser) onVulnerableRoadUser();
        else if (this == TrafficLightController) onTrafficLightController();
        else if (this == InfrastructureSensor) onInfrastructureSensor();
        else if (this == OnboardSensor) onOnboardSensor();
        else if (this == Software) onSoftware();
        else otherwise(Value);
    }
}
