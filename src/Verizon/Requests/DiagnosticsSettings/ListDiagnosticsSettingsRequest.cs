namespace Verizon.Requests.DiagnosticsSettings;

/// <summary>
/// The inputs of the ListDiagnosticsSettings operation.
/// </summary>
public sealed record ListDiagnosticsSettingsRequest
{
    /// <summary>
    /// Account identifier.
    /// </summary>
    public required string AccountName { get; init; }

    /// <summary>
    /// Devices list formatted as "id, kind"
    /// </summary>
    public required string Devices { get; init; }
}
