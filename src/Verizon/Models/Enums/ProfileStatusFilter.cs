using System;
using System.Text.Json.Serialization;
using Verizon.Core.Enum;

namespace Verizon.Models.Enums;

/// <summary>
/// The last status of the device's profile as a filter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ProfileStatusFilter>))]
public sealed record ProfileStatusFilter : OpenStringEnum<ProfileStatusFilter>
{
    private ProfileStatusFilter(string value) : base(value)
    {
    }

    public static readonly ProfileStatusFilter Enable = new("ENABLE");

    public static readonly ProfileStatusFilter Disable = new("DISABLE");

    public static readonly ProfileStatusFilter DownloadDisable = new("DOWNLOAD_DISABLE");

    public static readonly ProfileStatusFilter DownloadEnable = new("DOWNLOAD_ENABLE");

    public static readonly ProfileStatusFilter NotDownloaded = new("NOT_DOWNLOADED");

    public static readonly ProfileStatusFilter Unknown = new("UNKNOWN");

    public static readonly ProfileStatusFilter Delete = new("DELETE");

    public TResult Match<TResult>(Func<TResult> onEnable,
        Func<TResult> onDisable,
        Func<TResult> onDownloadDisable,
        Func<TResult> onDownloadEnable,
        Func<TResult> onNotDownloaded,
        Func<TResult> onUnknown,
        Func<TResult> onDelete,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Enable => onEnable(),
            _ when this == Disable => onDisable(),
            _ when this == DownloadDisable => onDownloadDisable(),
            _ when this == DownloadEnable => onDownloadEnable(),
            _ when this == NotDownloaded => onNotDownloaded(),
            _ when this == Unknown => onUnknown(),
            _ when this == Delete => onDelete(),
            _ => otherwise(Value)
        };

    public void Match(Action onEnable,
        Action onDisable,
        Action onDownloadDisable,
        Action onDownloadEnable,
        Action onNotDownloaded,
        Action onUnknown,
        Action onDelete,
        Action<string> otherwise)
    {
        if (this == Enable) onEnable();
        else if (this == Disable) onDisable();
        else if (this == DownloadDisable) onDownloadDisable();
        else if (this == DownloadEnable) onDownloadEnable();
        else if (this == NotDownloaded) onNotDownloaded();
        else if (this == Unknown) onUnknown();
        else if (this == Delete) onDelete();
        else otherwise(Value);
    }
}
