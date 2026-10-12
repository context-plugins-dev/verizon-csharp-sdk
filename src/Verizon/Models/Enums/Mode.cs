using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// the reporting mode of the tilt sensor
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Mode>))]
public sealed record Mode : OpenStringEnum<Mode>
{
    private Mode(string value) : base(value)
    {
    }

    public static readonly Mode ReportOnChange = new("reportOnChange");

    public TResult Match<TResult>(Func<TResult> onReportOnChange, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ReportOnChange => onReportOnChange(),
            _ => otherwise(Value)
        };

    public void Match(Action onReportOnChange, Action<string> otherwise)
    {
        if (this == ReportOnChange) onReportOnChange();
        else otherwise(Value);
    }
}
