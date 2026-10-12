using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Error Code.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ErrorResponseCode>))]
public sealed record ErrorResponseCode : OpenStringEnum<ErrorResponseCode>
{
    private ErrorResponseCode(string value) : base(value)
    {
    }

    public static readonly ErrorResponseCode Unauthorized = new("UNAUTHORIZED");

    public static readonly ErrorResponseCode InvalidAccess = new("INVALID_ACCESS");

    public static readonly ErrorResponseCode InvalidParameter = new("INVALID_PARAMETER");

    public static readonly ErrorResponseCode InternalError = new("INTERNAL_ERROR");

    public static readonly ErrorResponseCode Success = new("SUCCESS");

    public TResult Match<TResult>(Func<TResult> onUnauthorized,
        Func<TResult> onInvalidAccess,
        Func<TResult> onInvalidParameter,
        Func<TResult> onInternalError,
        Func<TResult> onSuccess,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Unauthorized => onUnauthorized(),
            _ when this == InvalidAccess => onInvalidAccess(),
            _ when this == InvalidParameter => onInvalidParameter(),
            _ when this == InternalError => onInternalError(),
            _ when this == Success => onSuccess(),
            _ => otherwise(Value)
        };

    public void Match(Action onUnauthorized,
        Action onInvalidAccess,
        Action onInvalidParameter,
        Action onInternalError,
        Action onSuccess,
        Action<string> otherwise)
    {
        if (this == Unauthorized) onUnauthorized();
        else if (this == InvalidAccess) onInvalidAccess();
        else if (this == InvalidParameter) onInvalidParameter();
        else if (this == InternalError) onInternalError();
        else if (this == Success) onSuccess();
        else otherwise(Value);
    }
}
