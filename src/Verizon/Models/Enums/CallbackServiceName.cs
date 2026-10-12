using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The name of the callback service.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CallbackServiceName>))]
public sealed record CallbackServiceName : OpenStringEnum<CallbackServiceName>
{
    private CallbackServiceName(string value) : base(value)
    {
    }

    public static readonly CallbackServiceName Location = new("Location");

    public static readonly CallbackServiceName DeviceLocation = new("DeviceLocation");

    public TResult Match<TResult>(Func<TResult> onLocation,
        Func<TResult> onDeviceLocation,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Location => onLocation(),
            _ when this == DeviceLocation => onDeviceLocation(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocation, Action onDeviceLocation, Action<string> otherwise)
    {
        if (this == Location) onLocation();
        else if (this == DeviceLocation) onDeviceLocation();
        else otherwise(Value);
    }
}
