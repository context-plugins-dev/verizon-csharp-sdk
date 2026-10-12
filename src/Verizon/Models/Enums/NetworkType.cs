using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The type of the device's network connection at the time of the request. If the device is on the Verizon cellular network it should use the "VZ" value otherwise the "non-VZ" value.
/// <para>
/// Devices on the Verizon network can directly access the ETX Message Exchange on the MEC (Mobile Edge Compute server)
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<NetworkType>))]
public sealed record NetworkType : OpenStringEnum<NetworkType>
{
    private NetworkType(string value) : base(value)
    {
    }

    public static readonly NetworkType Vz = new("VZ");

    public static readonly NetworkType NonVz = new("non-VZ");

    public TResult Match<TResult>(Func<TResult> onVz, Func<TResult> onNonVz, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Vz => onVz(),
            _ when this == NonVz => onNonVz(),
            _ => otherwise(Value)
        };

    public void Match(Action onVz, Action onNonVz, Action<string> otherwise)
    {
        if (this == Vz) onVz();
        else if (this == NonVz) onNonVz();
        else otherwise(Value);
    }
}
