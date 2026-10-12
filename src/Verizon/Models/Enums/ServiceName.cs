using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Service name
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ServiceName>))]
public sealed record ServiceName : OpenStringEnum<ServiceName>
{
    private ServiceName(string value) : base(value)
    {
    }

    public static readonly ServiceName Location = new("Location");

    public static readonly ServiceName Fota = new("fota");

    public TResult Match<TResult>(Func<TResult> onLocation, Func<TResult> onFota, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Location => onLocation(),
            _ when this == Fota => onFota(),
            _ => otherwise(Value)
        };

    public void Match(Action onLocation, Action onFota, Action<string> otherwise)
    {
        if (this == Location) onLocation();
        else if (this == Fota) onFota();
        else otherwise(Value);
    }
}
