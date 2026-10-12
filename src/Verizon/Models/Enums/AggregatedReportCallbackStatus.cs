using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// QUEUED or COMPLETED. Requests for IoT devices with cacheMode=0 (cached) have status=COMPLETED; all other requests are QUEUED.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AggregatedReportCallbackStatus>))]
public sealed record AggregatedReportCallbackStatus : OpenStringEnum<AggregatedReportCallbackStatus>
{
    private AggregatedReportCallbackStatus(string value) : base(value)
    {
    }

    public static readonly AggregatedReportCallbackStatus Queued = new("QUEUED");

    public static readonly AggregatedReportCallbackStatus Completed = new("COMPLETED");

    public TResult Match<TResult>(Func<TResult> onQueued, Func<TResult> onCompleted, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Queued => onQueued(),
            _ when this == Completed => onCompleted(),
            _ => otherwise(Value)
        };

    public void Match(Action onQueued, Action onCompleted, Action<string> otherwise)
    {
        if (this == Queued) onQueued();
        else if (this == Completed) onCompleted();
        else otherwise(Value);
    }
}
