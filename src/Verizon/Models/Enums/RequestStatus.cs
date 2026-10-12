using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The current status of the callback response.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<RequestStatus>))]
public sealed record RequestStatus : OpenStringEnum<RequestStatus>
{
    private RequestStatus(string value) : base(value)
    {
    }

    public static readonly RequestStatus Pending = new("Pending");

    public static readonly RequestStatus Success = new("Success");

    public static readonly RequestStatus Failure = new("Failure");

    public TResult Match<TResult>(Func<TResult> onPending,
        Func<TResult> onSuccess,
        Func<TResult> onFailure,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Pending => onPending(),
            _ when this == Success => onSuccess(),
            _ when this == Failure => onFailure(),
            _ => otherwise(Value)
        };

    public void Match(Action onPending, Action onSuccess, Action onFailure, Action<string> otherwise)
    {
        if (this == Pending) onPending();
        else if (this == Success) onSuccess();
        else if (this == Failure) onFailure();
        else otherwise(Value);
    }
}
