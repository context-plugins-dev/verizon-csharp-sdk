using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Status of the report.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ReportStatus>))]
public sealed record ReportStatus : OpenStringEnum<ReportStatus>
{
    private ReportStatus(string value) : base(value)
    {
    }

    public static readonly ReportStatus Queued = new("QUEUED");

    public static readonly ReportStatus Inprogress = new("INPROGRESS");

    public static readonly ReportStatus Completed = new("COMPLETED");

    public TResult Match<TResult>(Func<TResult> onQueued,
        Func<TResult> onInprogress,
        Func<TResult> onCompleted,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Queued => onQueued(),
            _ when this == Inprogress => onInprogress(),
            _ when this == Completed => onCompleted(),
            _ => otherwise(Value)
        };

    public void Match(Action onQueued, Action onInprogress, Action onCompleted, Action<string> otherwise)
    {
        if (this == Queued) onQueued();
        else if (this == Inprogress) onInprogress();
        else if (this == Completed) onCompleted();
        else otherwise(Value);
    }
}
