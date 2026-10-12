using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The subtype or subgroup of the client type. This further specifies the client type. For example it will specify if the client is a passenger car or a truck. See the ClientType description for the supported Subtypes for each client type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ClientSubtype>))]
public sealed record ClientSubtype : OpenStringEnum<ClientSubtype>
{
    private ClientSubtype(string value) : base(value)
    {
    }

    public static readonly ClientSubtype PassengerCar = new("PassengerCar");

    public static readonly ClientSubtype Truck = new("Truck");

    public static readonly ClientSubtype Bus = new("Bus");

    public static readonly ClientSubtype EmergencyVehicle = new("EmergencyVehicle");

    public static readonly ClientSubtype SchoolBus = new("SchoolBus");

    public static readonly ClientSubtype MaintenanceVehicle = new("MaintenanceVehicle");

    public static readonly ClientSubtype Pedestrian = new("Pedestrian");

    public static readonly ClientSubtype Bicycle = new("Bicycle");

    public static readonly ClientSubtype Scooter = new("Scooter");

    public static readonly ClientSubtype Motorcycle = new("Motorcycle");

    public static readonly ClientSubtype RoadSideUnit = new("RoadSideUnit");

    public static readonly ClientSubtype Camera = new("Camera");

    public static readonly ClientSubtype Lidar = new("Lidar");

    public static readonly ClientSubtype Radar = new("Radar");

    public static readonly ClientSubtype InductiveLoop = new("InductiveLoop");

    public static readonly ClientSubtype MagneticSensor = new("MagneticSensor");

    public static readonly ClientSubtype Platform = new("Platform");

    public static readonly ClientSubtype Application = new("Application");

    public static readonly ClientSubtype Na = new("NA");

    public TResult Match<TResult>(Func<TResult> onPassengerCar,
        Func<TResult> onTruck,
        Func<TResult> onBus,
        Func<TResult> onEmergencyVehicle,
        Func<TResult> onSchoolBus,
        Func<TResult> onMaintenanceVehicle,
        Func<TResult> onPedestrian,
        Func<TResult> onBicycle,
        Func<TResult> onScooter,
        Func<TResult> onMotorcycle,
        Func<TResult> onRoadSideUnit,
        Func<TResult> onCamera,
        Func<TResult> onLidar,
        Func<TResult> onRadar,
        Func<TResult> onInductiveLoop,
        Func<TResult> onMagneticSensor,
        Func<TResult> onPlatform,
        Func<TResult> onApplication,
        Func<TResult> onNa,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == PassengerCar => onPassengerCar(),
            _ when this == Truck => onTruck(),
            _ when this == Bus => onBus(),
            _ when this == EmergencyVehicle => onEmergencyVehicle(),
            _ when this == SchoolBus => onSchoolBus(),
            _ when this == MaintenanceVehicle => onMaintenanceVehicle(),
            _ when this == Pedestrian => onPedestrian(),
            _ when this == Bicycle => onBicycle(),
            _ when this == Scooter => onScooter(),
            _ when this == Motorcycle => onMotorcycle(),
            _ when this == RoadSideUnit => onRoadSideUnit(),
            _ when this == Camera => onCamera(),
            _ when this == Lidar => onLidar(),
            _ when this == Radar => onRadar(),
            _ when this == InductiveLoop => onInductiveLoop(),
            _ when this == MagneticSensor => onMagneticSensor(),
            _ when this == Platform => onPlatform(),
            _ when this == Application => onApplication(),
            _ when this == Na => onNa(),
            _ => otherwise(Value)
        };

    public void Match(Action onPassengerCar,
        Action onTruck,
        Action onBus,
        Action onEmergencyVehicle,
        Action onSchoolBus,
        Action onMaintenanceVehicle,
        Action onPedestrian,
        Action onBicycle,
        Action onScooter,
        Action onMotorcycle,
        Action onRoadSideUnit,
        Action onCamera,
        Action onLidar,
        Action onRadar,
        Action onInductiveLoop,
        Action onMagneticSensor,
        Action onPlatform,
        Action onApplication,
        Action onNa,
        Action<string> otherwise)
    {
        if (this == PassengerCar) onPassengerCar();
        else if (this == Truck) onTruck();
        else if (this == Bus) onBus();
        else if (this == EmergencyVehicle) onEmergencyVehicle();
        else if (this == SchoolBus) onSchoolBus();
        else if (this == MaintenanceVehicle) onMaintenanceVehicle();
        else if (this == Pedestrian) onPedestrian();
        else if (this == Bicycle) onBicycle();
        else if (this == Scooter) onScooter();
        else if (this == Motorcycle) onMotorcycle();
        else if (this == RoadSideUnit) onRoadSideUnit();
        else if (this == Camera) onCamera();
        else if (this == Lidar) onLidar();
        else if (this == Radar) onRadar();
        else if (this == InductiveLoop) onInductiveLoop();
        else if (this == MagneticSensor) onMagneticSensor();
        else if (this == Platform) onPlatform();
        else if (this == Application) onApplication();
        else if (this == Na) onNa();
        else otherwise(Value);
    }
}
