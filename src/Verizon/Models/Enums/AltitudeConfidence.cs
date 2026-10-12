using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// Absolute accuracy of a reported altitude value.
/// The value shall be set to:
/// - 0  - <c>alt-000-01</c>   - if the confidence value is equal to or less than 0,01 metre,
/// - 1  - <c>alt-000-02</c>   - if the confidence value is equal to or less than 0,02 metre and greater than 0,01 metre,
/// - 2  - <c>alt-000-05</c>   - if the confidence value is equal to or less than 0,05 metre and greater than 0,02 metre,
/// - 3  - <c>alt-000-10</c>   - if the confidence value is equal to or less than 0,1 metre and greater than 0,05 metre,
/// - 4  - <c>alt-000-20</c>   - if the confidence value is equal to or less than 0,2 metre and greater than 0,1 metre,
/// - 5  - <c>alt-000-50</c>   - if the confidence value is equal to or less than 0,5 metre and greater than 0,2 metre,
/// - 6  - <c>alt-001-00</c>   - if the confidence value is equal to or less than 1 metre and greater than 0,5 metre,
/// - 7  - <c>alt-002-00</c>   - if the confidence value is equal to or less than 2 metres and greater than 1 metre,
/// - 8  - <c>alt-005-00</c>   - if the confidence value is equal to or less than 5 metres and greater than 2 metres,
/// - 9  - <c>alt-010-00</c>   - if the confidence value is equal to or less than 10 metres and greater than 5 metres,
/// - 10 - <c>alt-020-00</c>   - if the confidence value is equal to or less than 20 metres and greater than 10 metres,
/// - 11 - <c>alt-050-00</c>   - if the confidence value is equal to or less than 50 metres and greater than 20 metres,
/// - 12 - <c>alt-100-00</c>   - if the confidence value is equal to or less than 100 metres and greater than 50 metres,
/// - 13 - <c>alt-200-00</c>   - if the confidence value is equal to or less than 200 metres and greater than 100 metres,
/// - 14 - <c>outOfRange</c>   - if the confidence value is out of range, i.e. greater than 200 metres,
/// - 15 - <c>unavailable</c>  - if the confidence value is unavailable.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AltitudeConfidence>))]
public sealed record AltitudeConfidence : OpenStringEnum<AltitudeConfidence>
{
    private AltitudeConfidence(string value) : base(value)
    {
    }

    public static readonly AltitudeConfidence Alt00001 = new("alt-000-01");

    public static readonly AltitudeConfidence Alt00002 = new("alt-000-02");

    public static readonly AltitudeConfidence Alt00005 = new("alt-000-05");

    public static readonly AltitudeConfidence Alt00010 = new("alt-000-10");

    public static readonly AltitudeConfidence Alt00020 = new("alt-000-20");

    public static readonly AltitudeConfidence Alt00050 = new("alt-000-50");

    public static readonly AltitudeConfidence Alt00100 = new("alt-001-00");

    public static readonly AltitudeConfidence Alt00200 = new("alt-002-00");

    public static readonly AltitudeConfidence Alt00500 = new("alt-005-00");

    public static readonly AltitudeConfidence Alt01000 = new("alt-010-00");

    public static readonly AltitudeConfidence Alt02000 = new("alt-020-00");

    public static readonly AltitudeConfidence Alt05000 = new("alt-050-00");

    public static readonly AltitudeConfidence Alt10000 = new("alt-100-00");

    public static readonly AltitudeConfidence Alt20000 = new("alt-200-00");

    public static readonly AltitudeConfidence OutOfRange = new("outOfRange");

    public static readonly AltitudeConfidence Unavailable = new("unavailable");

    public TResult Match<TResult>(Func<TResult> onAlt00001,
        Func<TResult> onAlt00002,
        Func<TResult> onAlt00005,
        Func<TResult> onAlt00010,
        Func<TResult> onAlt00020,
        Func<TResult> onAlt00050,
        Func<TResult> onAlt00100,
        Func<TResult> onAlt00200,
        Func<TResult> onAlt00500,
        Func<TResult> onAlt01000,
        Func<TResult> onAlt02000,
        Func<TResult> onAlt05000,
        Func<TResult> onAlt10000,
        Func<TResult> onAlt20000,
        Func<TResult> onOutOfRange,
        Func<TResult> onUnavailable,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Alt00001 => onAlt00001(),
            _ when this == Alt00002 => onAlt00002(),
            _ when this == Alt00005 => onAlt00005(),
            _ when this == Alt00010 => onAlt00010(),
            _ when this == Alt00020 => onAlt00020(),
            _ when this == Alt00050 => onAlt00050(),
            _ when this == Alt00100 => onAlt00100(),
            _ when this == Alt00200 => onAlt00200(),
            _ when this == Alt00500 => onAlt00500(),
            _ when this == Alt01000 => onAlt01000(),
            _ when this == Alt02000 => onAlt02000(),
            _ when this == Alt05000 => onAlt05000(),
            _ when this == Alt10000 => onAlt10000(),
            _ when this == Alt20000 => onAlt20000(),
            _ when this == OutOfRange => onOutOfRange(),
            _ when this == Unavailable => onUnavailable(),
            _ => otherwise(Value)
        };

    public void Match(Action onAlt00001,
        Action onAlt00002,
        Action onAlt00005,
        Action onAlt00010,
        Action onAlt00020,
        Action onAlt00050,
        Action onAlt00100,
        Action onAlt00200,
        Action onAlt00500,
        Action onAlt01000,
        Action onAlt02000,
        Action onAlt05000,
        Action onAlt10000,
        Action onAlt20000,
        Action onOutOfRange,
        Action onUnavailable,
        Action<string> otherwise)
    {
        if (this == Alt00001) onAlt00001();
        else if (this == Alt00002) onAlt00002();
        else if (this == Alt00005) onAlt00005();
        else if (this == Alt00010) onAlt00010();
        else if (this == Alt00020) onAlt00020();
        else if (this == Alt00050) onAlt00050();
        else if (this == Alt00100) onAlt00100();
        else if (this == Alt00200) onAlt00200();
        else if (this == Alt00500) onAlt00500();
        else if (this == Alt01000) onAlt01000();
        else if (this == Alt02000) onAlt02000();
        else if (this == Alt05000) onAlt05000();
        else if (this == Alt10000) onAlt10000();
        else if (this == Alt20000) onAlt20000();
        else if (this == OutOfRange) onOutOfRange();
        else if (this == Unavailable) onUnavailable();
        else otherwise(Value);
    }
}
