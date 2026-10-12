using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Possible response codes.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ResponseCode>))]
public sealed record ResponseCode : OpenStringEnum<ResponseCode>
{
    private ResponseCode(string value) : base(value)
    {
    }

    public static readonly ResponseCode InvalidAccess = new("INVALID_ACCESS");

    public static readonly ResponseCode InvalidParameter = new("INVALID_PARAMETER");

    public static readonly ResponseCode InternalError = new("INTERNAL_ERROR");

    public static readonly ResponseCode Success = new("SUCCESS");

    public TResult Match<TResult>(Func<TResult> onInvalidAccess,
        Func<TResult> onInvalidParameter,
        Func<TResult> onInternalError,
        Func<TResult> onSuccess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == InvalidAccess => onInvalidAccess(),
            _ when this == InvalidParameter => onInvalidParameter(),
            _ when this == InternalError => onInternalError(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onInvalidAccess,
        Action onInvalidParameter,
        Action onInternalError,
        Action onSuccess,
        Action<string> otherwise)
    {
        if (this == InvalidAccess) onInvalidAccess();
        else if (this == InvalidParameter) onInvalidParameter();
        else if (this == InternalError) onInternalError();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
