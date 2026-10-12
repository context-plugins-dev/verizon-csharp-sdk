using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Callback type. Must be 'Fota' for Software Management Services API.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CallbackService>))]
public sealed record CallbackService : OpenStringEnum<CallbackService>
{
    private CallbackService(string value) : base(value)
    {
    }

    public static readonly CallbackService Fota = new("Fota");

    public TResult Match<TResult>(Func<TResult> onFota, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fota => onFota(),
            _ => otherwise(Value)
        };

    public void Match(Action onFota, Action<string> otherwise)
    {
        if (this == Fota) onFota();
        else otherwise(Value);
    }
}
